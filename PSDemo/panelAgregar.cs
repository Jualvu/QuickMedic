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
    public partial class panelAgregar : Form
    {
        
        //Constructor
        public panelAgregar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            comboBox_Dias.DropDownStyle = ComboBoxStyle.DropDownList;
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

        //Funcion Mover y arrastrar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Comprobar hora introducida correcta

        private bool horaCorrecta()
        {
            if(textBox_Hora.Text == ("00") || textBox_Hora.Text == ("01") || textBox_Hora.Text == ("02") || textBox_Hora.Text == ("03") ||
               textBox_Hora.Text == ("04") || textBox_Hora.Text == ("05") || textBox_Hora.Text == ("06") ||
               textBox_Hora.Text == ("07") || textBox_Hora.Text == ("08") || textBox_Hora.Text == ("09") ||
               textBox_Hora.Text == ("10") || textBox_Hora.Text == ("11") || textBox_Hora.Text == ("12") ||
               textBox_Hora.Text == ("13") || textBox_Hora.Text == ("14") || textBox_Hora.Text == ("15") ||
               textBox_Hora.Text == ("16") || textBox_Hora.Text == ("17") || textBox_Hora.Text == ("18") ||
               textBox_Hora.Text == ("19") || textBox_Hora.Text == ("20") || textBox_Hora.Text == ("21") ||
               textBox_Hora.Text == ("22") || textBox_Hora.Text == ("23") || textBox_Hora.Text == ("24"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar minutos correctos
        private bool minutosCorrectos()
        {
            if (textBox_Minutos.Text == ("00") || textBox_Minutos.Text == ("01") || textBox_Minutos.Text == ("02") || textBox_Minutos.Text == ("03") ||
                textBox_Minutos.Text == ("04") || textBox_Minutos.Text == ("05") || textBox_Minutos.Text == ("06") ||
                textBox_Minutos.Text == ("07") || textBox_Minutos.Text == ("08") || textBox_Minutos.Text == ("09") ||
                textBox_Minutos.Text == ("10") || textBox_Minutos.Text == ("11") || textBox_Minutos.Text == ("12") ||
                textBox_Minutos.Text == ("13") || textBox_Minutos.Text == ("14") || textBox_Minutos.Text == ("15") ||
                textBox_Minutos.Text == ("16") || textBox_Minutos.Text == ("17") || textBox_Minutos.Text == ("18") ||
                textBox_Minutos.Text == ("19") || textBox_Minutos.Text == ("20") || textBox_Minutos.Text == ("21") ||
                textBox_Minutos.Text == ("22") || textBox_Minutos.Text == ("23") || textBox_Minutos.Text == ("24") ||
                textBox_Minutos.Text == ("25") || textBox_Minutos.Text == ("26") || textBox_Minutos.Text == ("27") ||
                textBox_Minutos.Text == ("28") || textBox_Minutos.Text == ("29") || textBox_Minutos.Text == ("30") ||
                textBox_Minutos.Text == ("31") || textBox_Minutos.Text == ("32") || textBox_Minutos.Text == ("33") ||
                textBox_Minutos.Text == ("34") || textBox_Minutos.Text == ("35") || textBox_Minutos.Text == ("36") ||
                textBox_Minutos.Text == ("37") || textBox_Minutos.Text == ("38") || textBox_Minutos.Text == ("39") ||
                textBox_Minutos.Text == ("40") || textBox_Minutos.Text == ("41") || textBox_Minutos.Text == ("42") ||
                textBox_Minutos.Text == ("43") || textBox_Minutos.Text == ("44") || textBox_Minutos.Text == ("45") ||
                textBox_Minutos.Text == ("46") || textBox_Minutos.Text == ("47") || textBox_Minutos.Text == ("48") ||
                textBox_Minutos.Text == ("49") || textBox_Minutos.Text == ("50") || textBox_Minutos.Text == ("51") ||
                textBox_Minutos.Text == ("52") || textBox_Minutos.Text == ("53") || textBox_Minutos.Text == ("54") ||
                textBox_Minutos.Text == ("55") || textBox_Minutos.Text == ("56") || textBox_Minutos.Text == ("57") ||
                textBox_Minutos.Text == ("58") || textBox_Minutos.Text == ("59"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Boton agregar medicamento
        private void btn_AgregarMiMedicamento(object sender, EventArgs e)
        {
            Principal objPrin = new Principal();

            MedicamentoDB medicamentos = new MedicamentoDB();
            Usuario us = new Usuario();

            try
            {
                if (!string.IsNullOrEmpty(textBox_Nombre.Text) &&
                    !string.IsNullOrEmpty(textBox_Dosis.Text) &&
                    !string.IsNullOrEmpty(textBox_Comentario.Text) &&
                    !string.IsNullOrEmpty(comboBox_Dias.Text) &&
                    !string.IsNullOrEmpty(textBox_Hora.Text) &&
                    !string.IsNullOrEmpty(textBox_Minutos.Text) &&
                    (horaCorrecta()==true) && (minutosCorrectos()==true))
                {
                    string hora = textBox_Hora.Text + ":" + textBox_Minutos.Text;
                    medicamentos.agregarMedicamento(textBox_Nombre.Text, textBox_Dosis.Text, textBox_Comentario.Text, comboBox_Dias.Text, hora, us.obtenerUsuarioActivo());
                    objPrin.refresh();
                    this.Close();
                }

                else if (!string.IsNullOrEmpty(textBox_Nombre.Text) &&
                        !string.IsNullOrEmpty(textBox_Dosis.Text) &&
                        !string.IsNullOrEmpty(textBox_Comentario.Text) &&
                        !string.IsNullOrEmpty(comboBox_Dias.Text) &&
                        !string.IsNullOrEmpty(textBox_Hora.Text) &&
                        !string.IsNullOrEmpty(textBox_Minutos.Text) &&
                        (horaCorrecta() == false) 
                        ||
                        !string.IsNullOrEmpty(textBox_Nombre.Text) &&
                        !string.IsNullOrEmpty(textBox_Dosis.Text) &&
                        !string.IsNullOrEmpty(textBox_Comentario.Text) &&
                        !string.IsNullOrEmpty(comboBox_Dias.Text) &&
                        !string.IsNullOrEmpty(textBox_Hora.Text) &&
                        !string.IsNullOrEmpty(textBox_Minutos.Text) &&
                        (minutosCorrectos() == false))
                {
                    MessageBox.Show("Escriba únicamente los dos digitos para la hora y los minutos. Sin espacios.");
                }


                else if (string.IsNullOrEmpty(textBox_Nombre.Text) ||
                    string.IsNullOrEmpty(textBox_Dosis.Text) ||
                    string.IsNullOrEmpty(textBox_Comentario.Text) ||
                    string.IsNullOrEmpty(comboBox_Dias.Text) ||
                    string.IsNullOrEmpty(textBox_Hora.Text) ||
                    string.IsNullOrEmpty(textBox_Minutos.Text))
                {
                    MessageBox.Show("Complete correctamente todos los datos");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar medicamento: " + ex.Message);
            }
        }

        //Arrastrar desde panel titulo
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Arrastrar desde label titulo
        private void label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Cerrar programa en la X
        private void picBox_CerrarVentanaAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
