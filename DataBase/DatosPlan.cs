using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosPlan : DatosConexionDB
    {
        int resultado = -1;
        public int AltaPlan(Plan objPlan)
        {
            try
            {
                conn.Open();
                string query = @" Insert into Planes (TipoPlan, FechaIngreso, FechaEgreso) 
                                    values ('"+ objPlan.TipoPlan + "'," 
                                     +"'" + objPlan.FechaIngreso + "'," 
                                     +"'" + objPlan.FechaEgreso + "')";

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
