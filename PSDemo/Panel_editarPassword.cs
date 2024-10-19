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

namespace PSDemo
{
    public partial class Panel_editarPassword : Form
    {
        //Constructor
        public Panel_editarPassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Este metodo da bordes redondealos al formulario o notificación usando un archivo .dll
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Funciones mover y arrastrar
        private void label_Title_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Funcion cerrar ventana en X
        private void picBox_CerrarVentanaEditar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //Boton editar password
        private void button_editarPassword_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            Usuario usuario = new Usuario();
            if (!string.IsNullOrEmpty(textBox_NuevaPassword.Text) &&
                !string.IsNullOrEmpty(textBox_NuevaPassword2.Text) &&
                textBox_NuevaPassword.Text == textBox_NuevaPassword2.Text)
            {
                password.editPassword(usuario.obtenerUsuarioActivo(), textBox_NuevaPassword.Text);
                MessageBox.Show("Cambio de contraseña exitoso");
                this.Close();
            }
            else if(!string.IsNullOrEmpty(textBox_NuevaPassword.Text) &&
                !string.IsNullOrEmpty(textBox_NuevaPassword2.Text) &&
                textBox_NuevaPassword.Text != textBox_NuevaPassword2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else if (string.IsNullOrEmpty(textBox_NuevaPassword.Text) ||
                 string.IsNullOrEmpty(textBox_NuevaPassword2.Text))
            {
                MessageBox.Show("Complete los campos correctamente");
            }
            else
            {
                MessageBox.Show("Error inesperado");
            }

        }
    }
}
