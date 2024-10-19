using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSDemo
{
    public partial class Panel_AjustesUsuario : Form
    {
        public Panel_AjustesUsuario()
        {
            InitializeComponent();
            refresh();
        }

        //Funcion para monstrar ventana agregar o editar
        private void MostrarPanel(object form1)
        {
            Form fh = form1 as Form;
            fh.ShowDialog();
            
        }

        //Funcion refresh
        public void refresh()
        {
            labelNombre();
            labelApellido1();
            labelApellido2();
        }

        //Obtener nombre en label
        public void labelNombre()
        {
            Usuario usuario = new Usuario();
            label_Nombre.Text = usuario.getNombre(usuario.obtenerUsuarioActivo());

        }

        //Obtener nombre en label
        public void labelApellido1()
        {
            Usuario usuario = new Usuario();
            label_Apellido1.Text = usuario.getApellido1(usuario.obtenerUsuarioActivo());

        }

        //Obtener nombre en label
        public void labelApellido2()
        {
            Usuario usuario = new Usuario();
            label_Apellido2.Text = usuario.getApellido2(usuario.obtenerUsuarioActivo());

        }

        //Boton editar datos usuario    
        private void button_EditarDatosUsuario_Click(object sender, EventArgs e)
        {
            MostrarPanel(new Panel_editarUsuario());
            refresh();
        }

        //Boton editar password
        private void button_EditarPassword_Click(object sender, EventArgs e)
        {
            MostrarPanel(new Panel_editarPassword());
            refresh();
        }
    }
}
