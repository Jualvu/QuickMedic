using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PSDemo
{
    class Usuario
    {
        //Getters and Setters
        string[] usuarios = new string[1];

        public string usuario_u { get; set; }
        public string nombre_u { get; set; }
        public string apellidoP_u { get; set; }
        public string apellidoM_u { get; set; }

        public Usuario()
        {

        }

        //Constructor de la clase Usuario
        public Usuario(string[] usuarios, string usuario_u, string nombre_u, string connectionString)
        {
            this.usuarios = usuarios;
            this.usuario_u = usuario_u;
            this.nombre_u = nombre_u;
            this.connectionString = connectionString;
        }



        //Conexion de la base datos
        private string connectionString = @"Data Source=LAPTOP-JULIO\SQLEXPRESS; Initial Catalog=QuickMedic3; User ID=localhost; Password=12345";

        //Esta sentencia SQL la cual se encarga de obtener de la BD el usuario actual
        public string obtenerUsuarioActivo()
        {
            string query = "SELECT usuario_u3 FROM u_Sesion WHERE estado = 1";
            string resultado = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        resultado = reader.GetString(0);

                    }
                    reader.Close();
                    connection.Close();

                    return resultado;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }


        //Ingresa en la BD un usuario que se define al llamar la función
        public void setUsuario(string usuario_u, string nombre_u, string aP, string aM)
        {
            string query = "INSERT INTO usuario(nombre_u,usuario_u,apellidoP_u,apellidoM_u) VALUES " +
                "(@nombre_u, @usuario_u, @apellidoP_u, @apellidoM_u)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre_u", nombre_u);
                command.Parameters.AddWithValue("@usuario_u", usuario_u);
                command.Parameters.AddWithValue("@apellidoP_u", aP);
                command.Parameters.AddWithValue("@apellidoM_u", aM);

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

        //Mediante una sentencia SQL obtiene de la BD el nombre del usuario actual
        public string getNombre(string usuario_u)
        {
            string query = "SELECT nombre_u FROM usuario WHERE (usuario_u=@usuario_u)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_u", usuario_u);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "No se encontro";
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }

        //Mediante una sentencia SQL obtiene de la BD el primer apellido del usuario actual
        public string getApellido1(string usuario_u)
        {
            string query = "SELECT apellidoP_u FROM usuario WHERE (usuario_u=@usuario_u)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_u", usuario_u);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "No se encontro";
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }

        //Mediante una sentencia SQL obtiene de la BD el segundo apellido del usuario actual
        public string getApellido2(string usuario_u)
        {
            string query = "SELECT apellidoM_u FROM usuario WHERE (usuario_u=@usuario_u)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_u", usuario_u);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "No se encontro";
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }

        //Mediante una sentencia SQL edita en la BD los datos del usuario actual
        public void editDatosUsuario(string usuario_u, string nombre_u, string apellidoP_u, string apellidoM_u)
        {
            string query = "UPDATE usuario set nombre_u=@nombre_u, apellidoP_u=@apellidoP_u, apellidoM_u=@apellidoM_u " +
                "WHERE (usuario_u=@usuario_u)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@usuario_u", usuario_u);
                command.Parameters.AddWithValue("@nombre_u", nombre_u);
                command.Parameters.AddWithValue("@apellidoP_u", apellidoP_u);
                command.Parameters.AddWithValue("@apellidoM_u", apellidoM_u);

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
