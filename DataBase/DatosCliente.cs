using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosCliente : DatosConexionDB
    {
        public int AltaCliente(Cliente objCliente)
        {
            int resultado = -1;

            try
            {
                conn.Open();

                string query = @" Insert into Cliente (Nombre, Domicilio, Telefono, Email, DNI)
                                    values ('" + objCliente.Nombre + "'," 
                                    + "'" + objCliente.Domicilio + "',"
                                    + "'" + objCliente.Telefono + "',"
                                    + "'" + objCliente.Email + "',"
                                    + "'" + objCliente.DNI + "')";

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
