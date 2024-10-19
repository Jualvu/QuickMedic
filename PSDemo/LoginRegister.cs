using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PSDemo
{
    public partial class LoginRegister : Form
    {
        //variable que almacena la conexión a la base de datos
        private string connectionString = @"Data Source=LAPTOP-JULIO\SQLEXPRESS; Initial Catalog=QuickMedic3; User ID=localhost; Password=12345";

        //Este metodo se encarga de redondear los bordes del formulario llamando a un archivo .dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Constructor de la clase
        public LoginRegister()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Esta función se encarga de dar la funcionalidad de mover y arrastrar el formulario con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Función del botón cerrar
        private void picBox_CloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("¿Desea salir?", "Cerrar Aplicación", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                sesionDesactivada();
                Application.Exit();
            }
        }

        //Funcion para monstrar ventana
        private void MostrarVentana(object form1)
        {
            Form fh = form1 as Form;
            fh.Show();
            this.Hide();
        }

        //Esta función da la opción al usuario de mover la ventada por la pantalla
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Este metodo se encarga de obtener los datos de un usuario de Base de Datos que correspondan
        //con los datos escritos en los text boxs
        public void login()
        {
            string usuario = textBox_Usuario.Text;
            string pass = textBox_Password.Text;

            string query = "SELECT password_p FROM passwords WHERE ( usuario_u1 = '" + usuario + "' AND password_p = '"+ pass +"')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string us = textBox_Usuario.Text;
                        MessageBox.Show("Has iniciado sesion correctamente");

                        sesionActiva(usuario);

                        MostrarVentana(new Principal());
                    }

                    else
                    {
                        MessageBox.Show("El ususario o la contraseña no existen");
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

        //Esta función obtiene mediante una sentencia SQL el usuario actual, ya que es el único con la sesión activa en la BD
        public void sesionActiva(string us)
        {

            string query = "SELECT usuario_u3 FROM u_Sesion WHERE ( usuario_u3 = '" + us + "')";
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                }

                reader.Close();
                connection.Close();
            }

            //Si el usuario no existe, entonces se agrega a la BD y se le coloca la sesión como activa
            if (exists==false) {

                string queryDos = "INSERT INTO u_Sesion (usuario_u3, estado) VALUES " +
                "(@usuario_u3, @estado)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryDos, connection);
                    command.Parameters.AddWithValue("@usuario_u3", us);
                    command.Parameters.AddWithValue("@estado", 1);

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

            //Sino entonces se actualiza la sesión como desactivada
            else
            {
                string queryDos = "UPDATE u_Sesion SET estado = 1 WHERE estado = 0 AND usuario_u3 = '"+ us +"';";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryDos, connection);

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

        //Funcion para descativar Sesion mediante la actualización del estado de la sesión del usuario actual
        //en la BD
        public void sesionDesactivada()
        {
            string queryDos = "UPDATE u_Sesion SET estado = 0 WHERE estado = 1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryDos, connection);

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

        
   


        //Boton iniciar sesion
        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(textBox_Password.Text) &&
                    !string.IsNullOrEmpty(textBox_Password.Text))
                {
                    login();
                    textBox_Usuario.Clear();
                    textBox_Password.Clear();
                }

                else if(string.IsNullOrEmpty(textBox_Password.Text) ||
                    string.IsNullOrEmpty(textBox_Password.Text))
                {
                    MessageBox.Show("Complete los datos correctamente");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error con la base de Datos" + ex.Message);
            }

        }

        //Boton Registrarse
        private void button_Register_Click(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            Password password = new Password();
            try
            {
                if (textBox_PasswordRegister.Text == textBox_ConfirmPasswordRegister.Text &&
                    !string.IsNullOrEmpty(textBox_UsuarioRegister.Text) &&
                    !string.IsNullOrEmpty(textBox_NameRegister.Text) &&
                    !string.IsNullOrEmpty(txtApellP.Text) &&
                    !string.IsNullOrEmpty(txtApellM.Text) &&
                    !string.IsNullOrEmpty(textBox_PasswordRegister.Text) &&
                    !string.IsNullOrEmpty(textBox_ConfirmPasswordRegister.Text))

                {
                    usuarios.setUsuario(textBox_UsuarioRegister.Text, textBox_NameRegister.Text, txtApellP.Text, txtApellM.Text);
                    password.setPassword(textBox_PasswordRegister.Text, textBox_UsuarioRegister.Text);

                    MessageBox.Show("Te has registrado exitosamente");

                    textBox_UsuarioRegister.Clear();
                    textBox_NameRegister.Clear();
                    textBox_PasswordRegister.Clear();
                    textBox_ConfirmPasswordRegister.Clear();
                    txtApellP.Clear();
                    txtApellM.Clear();
                }

                else if (textBox_PasswordRegister.Text != textBox_ConfirmPasswordRegister.Text &&
                    !string.IsNullOrEmpty(textBox_UsuarioRegister.Text) &&
                    !string.IsNullOrEmpty(textBox_NameRegister.Text) &&
                    !string.IsNullOrEmpty(txtApellP.Text) &&
                    !string.IsNullOrEmpty(txtApellM.Text) &&
                    !string.IsNullOrEmpty(textBox_PasswordRegister.Text) &&
                    !string.IsNullOrEmpty(textBox_ConfirmPasswordRegister.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden. Inténtelo de nuevo.");
                }

                else if (string.IsNullOrEmpty(textBox_UsuarioRegister.Text) ||
                    string.IsNullOrEmpty(textBox_NameRegister.Text) ||
                    string.IsNullOrEmpty(txtApellP.Text) ||
                    string.IsNullOrEmpty(txtApellM.Text) ||
                    string.IsNullOrEmpty(textBox_PasswordRegister.Text) ||
                    string.IsNullOrEmpty(textBox_ConfirmPasswordRegister.Text))
                {
                    MessageBox.Show("Complete correctamente todos los espacios");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ya existe un usuario registrado como: "+textBox_UsuarioRegister.Text);
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_See.Checked)
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '*';
            }
        }

        private void cb_See2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_See2.Checked)
            {
                textBox_PasswordRegister.PasswordChar = '\0';
                textBox_ConfirmPasswordRegister.PasswordChar = '\0';
            }
            else
            {
                textBox_PasswordRegister.PasswordChar = '*';
                textBox_ConfirmPasswordRegister.PasswordChar = '*';
            }
        }

        private void textBox_NameRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
