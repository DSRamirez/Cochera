using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosCliente : DatosConexionDB
    {
        public int AltaCliente(Cliente objCliente) //ref 
        {
            int resultado = -1;

            try
            {
                conn.Open();

                string query = @"Insert into Cliente(Nombre, Domicilio, Telefono, Email, DNI)
                                values('" + objCliente.Nombre + "',"
                                + "'" + objCliente.Domicilio + "',"
                                + "'" + objCliente.Telefono + "',"
                                + "'" + objCliente.Email + "',"
                                + "'" + objCliente.DNI + "')";

                SqlCommand command = new SqlCommand(query, conn);

                //command.CommandText = "RecuperarUltimoID";
                //command.CommandType = CommandType.StoredProcedure;
                //SqlParameter parameterid = new SqlParameter("Id_Cliente", SqlDbType.Int);
                //parameterid.Direction = ParameterDirection.Output;
                //command.Parameters.Add(parameterid);
                ////SqlDataReader leer = command.ExecuteReader();
                ////objCliente.ID_Cliente = Convert.ToInt32(leer);


                resultado = command.ExecuteNonQuery();

            }
            catch (Exception pepe)
            {

                throw pepe;
            }
            finally
            {
                conn.Close();
            }

            return resultado;
        }
    }
}