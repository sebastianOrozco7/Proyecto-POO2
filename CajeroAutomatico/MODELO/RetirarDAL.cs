using CajeroAutomatico.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    internal class RetirarDAL
    {

        ConexionDB conexionDB = new ConexionDB();
        public void Retirar(TextBox txbValorIngresado)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    string QuerySelect = "SELECT Saldo FROM Cuentas WHERE IdUsuario = @idusuario";

                    int SaldoUsuario = 0;
                    int NuevoSaldo = 0;

                    using (SqlCommand ComandoSelect = new SqlCommand(QuerySelect, conexion))
                    {
                        ComandoSelect.Parameters.AddWithValue("@idusuario", DatosGlobales.NumeroDocumento);
                        object valor = ComandoSelect.ExecuteScalar();

                        if (valor != null)
                        {
                            SaldoUsuario = Convert.ToInt32(valor);
                        }
                    }

                    int ValorIngresado = Convert.ToInt32(txbValorIngresado.Text);

                    if (ValorIngresado < SaldoUsuario)
                    {
                        NuevoSaldo = SaldoUsuario - ValorIngresado;

                        string QueryUpdate = "UPDATE CUENTAS SET Saldo = @NuevoSaldo WHERE IdUsuario = @IdUsuario";

                        using (SqlCommand ComandoUpdate = new SqlCommand(QueryUpdate, conexion))
                        {
                            ComandoUpdate.Parameters.AddWithValue("@NuevoSaldo", NuevoSaldo);
                            ComandoUpdate.Parameters.AddWithValue("@IdUsuario", DatosGlobales.NumeroDocumento);

                            ComandoUpdate.ExecuteNonQuery();
                        }
                        MessageBox.Show("Retiro Exitoso","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
