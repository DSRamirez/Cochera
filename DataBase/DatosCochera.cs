using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosCochera : DatosConexionDB
    {
        int resultado = -1;
        public int AltaCochera(Cochera objCochera) // ref y int idcliente, int idplan, int idvehiculo
        {
            try
            {
                conn.Open();
                string query = @" Insert into Cochera (NumeroCochera)
                                    values ('"+ objCochera.NumeroCochera + "')";

                SqlCommand command = new SqlCommand(query, conn);

                resultado = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return resultado;
        }
    }
}
