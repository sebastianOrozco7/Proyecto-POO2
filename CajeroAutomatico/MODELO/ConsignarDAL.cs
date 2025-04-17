using CajeroAutomatico.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    internal class ConsignarDAL
    {
        ConexionDB conexionDB = new ConexionDB();

        public void Consignar(TextBox txbValorConsignacion)
        {
            try
            {
               using(SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    float ValorConsignacion = Convert.ToSingle(txbValorConsignacion.Text);

                    string Query = "UPDATE Cuentas SET Saldo = @NuevoSaldo WHERE IdUsuario = @idusuario";

                    using (SqlCommand comando = new SqlCommand(Query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NuevoSaldo", ValorConsignacion);
                        comando.Parameters.AddWithValue("@idusuario", DatosGlobales.NumeroDocumento);
                        int FilasAfectadas = comando.ExecuteNonQuery();

                        if (FilasAfectadas > 0)
                        {
                            MessageBox.Show("Consignacion Exitosa", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Consignacion erronea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
