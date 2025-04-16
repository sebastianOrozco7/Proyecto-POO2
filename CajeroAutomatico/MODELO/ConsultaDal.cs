using CajeroAutomatico.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    class ConsultaDal
    {
        Cuenta cuenta = new Cuenta();
        ConexionDB conexionDB = new ConexionDB();
        
        public string ConsultarSaldo(int idUsuario)
        {
            
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                string Query = "SELECT Saldo FROM Cuentas WHERE IdUsuario = @IdUsuario";
                using (SqlCommand comando = new SqlCommand(Query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                        return "$ " + resultado.ToString();
                    else
                        return "Cuenta no encontrada";
                }
            }
        }


    }

}

