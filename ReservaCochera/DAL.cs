using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ReservaCochera
{
    public class DAL
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Garage;Data Source=DESKTOP-B1G1PMH");

        #region Insert Plan

        public void InsertPlan()
        {
            Plan plan = new Plan();
            try
            {
                conn.Open();

                string query = @" 
                INSERT INTO Planes   
                (TipoPlan, FechaIngreso, FechaEgreso)
                VALUES (@TipoPlan, @FechaIngreso, @FechaEgreso)";

                SqlParameter tipoPlan = new SqlParameter("@TipoPlan", plan.TipoPlan);
                SqlParameter fechaingreso = new SqlParameter("@FechaIngreso", plan.FechaIngreso);
                SqlParameter fechaegreso = new SqlParameter("@FechaEgreso", plan.FechaEgreso);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(tipoPlan);
                command.Parameters.Add(fechaingreso);
                command.Parameters.Add(fechaegreso);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        #endregion

        #region Insert Vehiculo
        public void InsertVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            try
            {
                conn.Open();

                string query = @" 
                INSERT INTO Vehiculo     
                (Dominio, Modelo, Marca)
                VALUES (@Dominio, @Modelo, @Marca)";

                SqlParameter dominio = new SqlParameter("@Dominio", vehiculo.Dominio);
                SqlParameter modelo = new SqlParameter("@Modelo", vehiculo.Modelo);
                SqlParameter marca = new SqlParameter(@"Marca", vehiculo.Marca);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(dominio);
                command.Parameters.Add(modelo);
                command.Parameters.Add(marca);


                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        #endregion

        #region Insert Cochera

        public void InsertCochera()
        {
            Cochera cochera = new Cochera();
            try
            {
                conn.Open();
                string query = @" 
                INSERT INTO Cochera 
                (NumeroCochera, ID_Vehiculo, ID_Plan)
                VALUES (@NumeroCochera, @ID_Vehiculo, @ID_Plan)";


                SqlParameter numeroCochera = new SqlParameter("@NumeroCochera", cochera.ID_Cochera);
                SqlParameter idvehiculo = new SqlParameter("@ID_Vehiculo", cochera.ID_Vehiculo);
                SqlParameter idplan = new SqlParameter("@ID_Plan", cochera.ID_Plan);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumeroCochera", cochera.ID_Cochera);
                command.Parameters.AddWithValue("@ID_Vehiculo", cochera.ID_Cochera);
                command.Parameters.AddWithValue("@ID_Plan", cochera.ID_Cochera);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        //public int GetId(int ID) 
        //{
        //    try
        //    {
        //        conn.Open();
        //        string query = @"Select ID_Vehiculo from Vehiculo " + ID;

        //        SqlCommand command = new SqlCommand(query, conn);

        //        command.ExecuteNonQuery();

        //        return 0;

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally { conn.Close(); }
        //}

        #endregion

        #region Insert Cliente
        public void InsertCliente ()
        {
            Cliente cliente = new Cliente();
            try
            {
                conn.Open();
                string query = @" 
                INSERT INTO Cliente     
                (Nombre, DNI, Domicilio, Telefono, Email)
                VALUES (@Nombre, @DNI, @Domicilio, @Telefono, @Email)";
                

                SqlParameter nombre = new SqlParameter("@Nombre", cliente.Nombre);
                SqlParameter dni = new SqlParameter("@DNI", cliente.DNI);
                SqlParameter domicilio = new SqlParameter(@"Domicilio", cliente.Domicilio);
                SqlParameter telefono = new SqlParameter("@Telefono", cliente.Telefono);
                SqlParameter email = new SqlParameter("@Email", cliente.Email);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombre);
                command.Parameters.Add(dni);
                command.Parameters.Add(domicilio);
                command.Parameters.Add(telefono);
                command.Parameters.Add(email);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        #endregion

    }
}
