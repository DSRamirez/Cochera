using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosVehiculo : DatosConexionDB
    {
        int resultado = -1;
        public int AltaVehiculo(Vehiculo objVehiculo) //ref - int IdCliete
        {
            try
            {
                conn.Open();
                string query = @" Insert into Vehiculo (TipoVehiculo, Dominio, Modelo, Marca) 
                                  values ('" + objVehiculo.TipoVehiculo + "',"
                                  + "'" + objVehiculo.Dominio + "',"
                                  + "'" + objVehiculo.Modelo + "',"
                                  + "'" + objVehiculo.Marca + "')";
               // +IdCliete.ToString();

                SqlCommand command = new SqlCommand(query, conn);

                resultado = command.ExecuteNonQuery();
                //SqlCommand command1 = new SqlCommand();
                //command1.Connection = conn;
                //command1.CommandText = "RecuperarUltimoID";
                //command1.CommandType = CommandType.StoredProcedure;
                //SqlDataReader leer;
                //leer = command1.ExecuteReader();
                //objVehiculo.Id_Vehiculo = Convert.ToInt32(leer);

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
