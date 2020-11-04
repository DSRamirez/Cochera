using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosVehiculo : DatosConexionDB
    {
        int resultado = -1;
        public int AltaVehiculo(Vehiculo objVehiculo)
        {
            try
            {
                conn.Open();
                string query = @" Insert into Vehiculo (TipoVehiculo, Dominio, Modelo, Marca) 
                                    values ('" + objVehiculo.TipoVehiculo + "',"
                                    + "'" + objVehiculo.Dominio + "'," 
                                    + "'" + objVehiculo.Modelo + "',"
                                    + "'" + objVehiculo.Marca + "')";

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
