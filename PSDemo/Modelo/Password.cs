using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PSDemo
{
    internal class Password
    {
        public string password_p { get; set; }
        public string usuario_u1 { get; set; }

        //Conexion a la base de datos
        private string connectionString = @"Data Source=LAPTOP-JULIO\SQLEXPRESS; Initial Catalog=QuickMedic3; User ID=localhost; Password=12345";

        //Hace una sentencia SQL en la BD (Base de datos) donde se agrega la contraseña del usuario registrado
        public void setPassword(string password_p, string usuario_u1)
        {
            string queryPassword = "INSERT INTO passwords (password_p, usuario_u1) VALUES (@password_p, @usuario_u1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryPassword, connection);

                command.Parameters.AddWithValue("@password_p", password_p);
                command.Parameters.AddWithValue("@usuario_u1", usuario_u1);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }

            }

        }

        //Al igual que la función anterior, bajo una sentencia edita la contraseña del usuario que inició sesión
        public void editPassword(string usuario_u1, string Password1)
        {
            string query = "UPDATE passwords set password_p=@Password1 " +
                "WHERE (usuario_u1=@usuario_u1)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@usuario_u1", usuario_u1);
                command.Parameters.AddWithValue("@Password1", Password1);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }
    }
}
