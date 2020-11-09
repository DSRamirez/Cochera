using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosConexionDB
    {

            public SqlConnection conn;
            public string CadenaConexion = @"Data Source=DESKTOP-B1G1PMH;Initial Catalog=Garage;Integrated Security=True;"; 
            public DatosConexionDB()
            {
                conn = new SqlConnection(CadenaConexion);
            }
            public SqlConnection AbrirConexion()
            {
                try
                {
                    if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                }
                catch (Exception e)
                {

                    throw new Exception("Error al abrir la base de datos", e);
                }
            return conn;
            }
            public SqlConnection CerrarConexion()
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception e)
                {

                    throw new Exception("Error al cerrar la base de datos", e);
                }
            return conn;
            }
    }
}
