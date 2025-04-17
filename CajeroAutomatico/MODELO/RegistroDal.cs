using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.VISTA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    public class RegistroDal
    {
        ConexionDB conexionDB = new ConexionDB();
        Usuario usuario = new Usuario();
        public void RegistrarNuevoUsuario(TextBox txbNombre, TextBox txbApellido, TextBox txbCorreo, TextBox txbTelefono, TextBox txbNumeroDocumento, TextBox txbContraseña,TextBox txbTipoCuenta, ComboBox cmbTipoDocumento)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    usuario.Nombre = txbNombre.Text;
                    usuario.Apellido = txbApellido.Text;
                    usuario.Correo = txbCorreo.Text;
                    usuario.Telefono = txbTelefono.Text;
                    usuario.NumeroDocumento = Convert.ToInt32(txbNumeroDocumento.Text);
                    usuario.TipoDocumento = cmbTipoDocumento.Text;
                    usuario.TipoCuenta = txbTipoCuenta.Text;
                    usuario.Contraseña = Convert.ToInt32(txbContraseña.Text);

                    string QueryUsuario = "INSERT INTO Usuario (Nombre, Apellido, Correo, Telefono, TipoDocumento,TipoCuenta,NumeroDocumento,Contraseña) " +
                                   "VALUES (@Nombre, @Apellido,@Correo,@Telefono,@TipoDocumento,@TipoCuenta,@NumeroDocumento,@Contraseña)";

                    using (SqlCommand comando = new SqlCommand(QueryUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                        comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        comando.Parameters.AddWithValue("@TipoDocumento", usuario.TipoDocumento);
                        comando.Parameters.AddWithValue("@TipoCuenta", usuario.TipoCuenta);
                        comando.Parameters.AddWithValue("@NumeroDocumento", usuario.NumeroDocumento);
                        comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                        comando.ExecuteNonQuery();
                    }
                   

                    string QueryCuentas = "INSERT INTO Cuentas (IdUsuario, TipoCuenta, Saldo) VALUES (@idusuario,@tipocuenta,@saldo)";
                    using (SqlCommand comando = new SqlCommand(QueryCuentas, conexion))
                    {
                        comando.Parameters.AddWithValue("@idusuario", usuario.NumeroDocumento);
                        comando.Parameters.AddWithValue("@tipocuenta", usuario.TipoCuenta);
                        comando.Parameters.AddWithValue("@saldo", 0);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
