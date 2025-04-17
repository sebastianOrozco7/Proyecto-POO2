using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.VISTA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    internal class IniciarSesionDAL
    {

        ConexionDB conexionDB = new ConexionDB();
        Usuario usuario = new Usuario();
        ConsultaDal consultaDal = new ConsultaDal();
        
        public void InicioSesion(TextBox txbUsuario, TextBox txbContraseña)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    DatosGlobales.NumeroDocumento = Convert.ToInt32(txbUsuario.Text);
                    usuario.Contraseña = Convert.ToInt32(txbContraseña.Text);

                    string Query = "SELECT COUNT(*) FROM Usuario WHERE NumeroDocumento = @usuario AND Contraseña = @contraseña";

                    using (SqlCommand comando = new SqlCommand(Query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", DatosGlobales.NumeroDocumento);
                        comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);

                        int Cuenta = (int)comando.ExecuteScalar();

                        if (Cuenta > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OpcionesUsuarioForm opcionesUsuarioForm = new OpcionesUsuarioForm();
                            opcionesUsuarioForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error en la base de datos: {sqlEx.Message}", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show($"Error de formato: {formatEx.Message}", "Valor ingresado incorrectamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error inesperado: {Ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

