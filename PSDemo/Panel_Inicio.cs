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
    public partial class Panel_Inicio : Form
    {
        public Panel_Inicio()
        {
            InitializeComponent();
        }


        //Actualiza la tabla con los datos al cargar el panel
        private void Panel_Inicio_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //Funcion de Refreshs
        private void refresh()
        {
            MedicamentoDB medicamentos = new MedicamentoDB();
            dataGridView_Medicamentos.DataSource = medicamentos.GetMedicamentos();
        }


      
    }
}
