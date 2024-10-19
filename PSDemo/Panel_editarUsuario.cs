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
    public partial class Panel_editarUsuario : Form
    {
        public Panel_editarUsuario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadData();
        }

        //Funcion para cargar los datos del usuario
        private void LoadData()
        {
            Usuario usuario = new Usuario();
            textBox_NuevoNombre.Text = usuario.getNombre(usuario.obtenerUsuarioActivo());
            textBox_Apellido1.Text = usuario.getApellido1(usuario.obtenerUsuarioActivo());
            textBox_Apellido2.Text = usuario.getApellido2(usuario.obtenerUsuarioActivo());
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
        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Funcion cerrar ventana en X
        private void picBox_CerrarVentanaEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion editar datos Usuario
        private void button_editarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (!string.IsNullOrEmpty(textBox_NuevoNombre.Text) &&
                !string.IsNullOrEmpty(textBox_Apellido1.Text) &&
                !string.IsNullOrEmpty(textBox_Apellido2.Text))
            {
                usuario.editDatosUsuario(usuario.obtenerUsuarioActivo(), textBox_NuevoNombre.Text,
                textBox_Apellido1.Text, textBox_Apellido2.Text);
                this.Close();
            }
            else if(string.IsNullOrEmpty(textBox_NuevoNombre.Text) ||
                string.IsNullOrEmpty(textBox_Apellido1.Text) ||
                string.IsNullOrEmpty(textBox_Apellido2.Text))
            {
                MessageBox.Show("Complete los campos correctamente");
            }
            else
            {
                MessageBox.Show("Error inesperado");
            }
            
        }

        private void textBox_NuevoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
