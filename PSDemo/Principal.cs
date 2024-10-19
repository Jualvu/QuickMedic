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
    public partial class Principal : Form
    {
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

        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            AbrirPanel(new Panel_Inicio());
            refresh();

        }


        //Funcion Mover y arrastrar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //Funcion abrir panel
        private void AbrirPanel(object form1)
        {
            if (this.panelDock.Controls.Count > 0)
                this.panelDock.Controls.RemoveAt(0);
            Form fh = form1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(fh);
            this.panelDock.Tag = fh;
            fh.Show();
            
        }

        //Boton Inicio
        private void btnInicio(object sender, EventArgs e)
        {
            AbrirPanel(new Panel_Inicio());
        }

        //Boton Medicamentos
        private void btnMedicamentos(object sender, EventArgs e)
        {
            AbrirPanel(new PanelMedicamentos());
            Usuario us = new Usuario();
        }

        //Boton Ajustes de usuario
        private void btnAjustesUsuario(object sender, EventArgs e)
        {
            AbrirPanel(new Panel_AjustesUsuario());
        }

        //Boton Cerrar sesion
        private void btnCerrarSesion(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
                LoginRegister loginRegister = new LoginRegister();
                loginRegister.sesionDesactivada();
                loginRegister.Show();
            }
        }

        //Funcion para arrastrar desde el panel de arriba
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Boton para salir del programa
        private void picBox_CerrarPrograma_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("¿Desea salir?", "Cerrar Aplicación", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
                LoginRegister log = new LoginRegister();

                log.sesionDesactivada();
            }
        }


        //Funcion de Refresh
        public void refresh()
        {
            MedicamentoDB medicamentos = new MedicamentoDB();
            dataGridView_Medicamentos.DataSource = medicamentos.GetMedicamentos();
        }

        //Funcion para monstrar ventana agregar o editar
        private void MostrarPanel(object form1)
        {
            Form fh = form1 as Form;
            fh.ShowDialog();
        }

        //Funcion obtiene la hora actual
        public int ticks = 0;
        private void hora_dia_Tick(object sender, EventArgs e)
        {
             DateTime dt = DateTime.Now;

            dt = DateTime.Now;
            string DayofWEEk = dt.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));
            txtdia.Text = DayofWEEk;
            txtReloj.Text = DateTime.Now.ToShortTimeString();
            string hora = txtReloj.Text;
            string fecha = txtdia.Text;
        }

        //Funcion que compara hora medicamento con hora actual
        private void alarma_Principal_Tick(object sender, EventArgs e)
        {
              ticks++;
            if (ticks == 25)
            {
                ticks = 0;
                alarma_Principal.Start();
                while (ticks == 0)
                {
                    int x = dataGridView_Medicamentos.Rows.Count;
 
                   foreach (DataGridViewRow row in dataGridView_Medicamentos.Rows)
                   {
                       if(row.Cells[5].Value.ToString() == txtReloj.Text)
                       {
                           if (row.Cells[4].Value.ToString() == txtdia.Text)
                           {
                                MostrarPanel(new Panel_Alerta());
                           }
                       }
                   }
                   break;
                } 
            } 
        }
    }
}
