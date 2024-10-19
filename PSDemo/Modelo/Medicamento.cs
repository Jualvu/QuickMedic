using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace PSDemo
{
    //Constructor
    public class Medicamento
    {
        public int clave_m { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Comentario { get; set; }
        public string día { get; set; }
        public string hora { get; set; }
    }

    //Anidamiento de clases
    public class MedicamentoDB
    {

        //Corresponde a la conexión a la base de datos (Ctrl+H para cambiar por la conexión necesaria)
        private string connectionString = @"Data Source=LAPTOP-JULIO\SQLEXPRESS; Initial Catalog=QuickMedic3; User ID=localhost; Password=12345";

        //Esta función devuelve un objeto de tipo de la clase Medicamento que está dentro de una array dinámico
        //esto se hace mediante una consulta SQL que obtiene los datos del usuario
        public List<Medicamento> GetMedicamentos()
        {
            List<Medicamento> medicamentos = new List<Medicamento>();

            Usuario us = new Usuario();

            string query = "SELECT clave_m, nombre_m, dosis_m, comentario_m, dia_m, hora_m FROM medicamentos WHERE (usuario_u2 = '" + us.obtenerUsuarioActivo() + "')";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Medicamento medicamento = new Medicamento();

                        medicamento.clave_m = reader.GetInt32(0);
                        medicamento.Nombre = reader.GetString(1);
                        medicamento.Dosis = reader.GetString(2);
                        medicamento.Comentario = reader.GetString(3);
                        medicamento.día = reader.GetString(4);
                        medicamento.hora = reader.GetString(5);


                        medicamentos.Add(medicamento);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }

            return medicamentos;
        }


        //Mediante un query SQL ingresa a la base de datos los datos ingresados al llamar la clase
        public void agregarMedicamento(string Nombre, string Dosis, string Comentario, string día, string hora, string usuario_u2)
        {
            string query = "INSERT INTO medicamentos(nombre_m,dosis_m,comentario_m, dia_m, hora_m, usuario_u2) VALUES " +
                "(@Nombre, @Dosis, @Comentario, @día, @hora, @usuario_u2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Dosis", Dosis);
                command.Parameters.AddWithValue("@Comentario", Comentario);
                command.Parameters.AddWithValue("@día", día);
                command.Parameters.AddWithValue("@hora", hora);
                command.Parameters.AddWithValue("@usuario_u2", usuario_u2);

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


        //Mediante un query SQL actualiza en la base de datos los datos ingresados al llamar la clase que correspondan con el usuario que use el programa
        public void editarMedicamento(string Nombre, string Dosis, string Comentario, string día, string hora, string usuario_u2, int clave_m)
        {
            string query = "UPDATE medicamentos set nombre_m=@Nombre, dosis_m=@Dosis, comentario_m=@Comentario, dia_m=@día, hora_m=@hora " +
                     "WHERE (clave_m=@clave_m AND usuario_u2=@usuario_u2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Dosis", Dosis);
                command.Parameters.AddWithValue("@Comentario", Comentario);
                command.Parameters.AddWithValue("@día", día);
                command.Parameters.AddWithValue("@hora", hora);
                command.Parameters.AddWithValue("@usuario_u2", usuario_u2);
                command.Parameters.AddWithValue("@clave_m", clave_m);

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

        //Hace una consulta a la base de datos donde obtiene los medicamentos que correspondan con el usuario que inició sesión
        public Medicamento GetMedicamentosId(int clave_m)
        {

            LoginRegister user = new LoginRegister();
            Usuario us = new Usuario();

            string query = "SELECT clave_m, nombre_m, dosis_m, comentario_m FROM medicamentos" +
                " WHERE (clave_m=@clave_m AND usuario_u2 = '" + us.obtenerUsuarioActivo() + "')";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@clave_m", clave_m);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    Medicamento medicamento = new Medicamento();

                    medicamento.clave_m = reader.GetInt32(0);
                    medicamento.Nombre = reader.GetString(1);
                    medicamento.Dosis = reader.GetString(2);
                    medicamento.Comentario = reader.GetString(3);

                    reader.Close();
                    connection.Close();

                    return medicamento;

                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }

        //Hace una sentencia SQL que borra los medicamentos del usuario digitado al llamar la función
        public void eliminarMedicamento(int clave_m, string usuario_u2)
        {
            string query = "DELETE FROM medicamentos WHERE (clave_m=@clave_m AND usuario_u2=@usuario_u2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_u2", usuario_u2);
                command.Parameters.AddWithValue("@clave_m", clave_m);

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

        public void prueba()
        {
            Label

        }
    }
}