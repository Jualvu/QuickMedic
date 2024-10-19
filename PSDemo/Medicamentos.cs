using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PSDemo
{
    public partial class PanelMedicamentos : Form
    {
        //variable conexion a la BD
        private string connectionString = @"Data Source=LAPTOP-JULIO\SQLEXPRESS; Initial Catalog=QuickMedic3; User ID=localhost; Password=12345";

        //Funcion para obtener lista medicamentos mediante un query SQL
        public bool ComprobarMedicamentos()
        {
            Usuario us = new Usuario();

            string query = "SELECT clave_m, nombre_m, dosis_m, comentario_m, dia_m, hora_m FROM medicamentos WHERE (usuario_u2 = '" + us.obtenerUsuarioActivo() + "')";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        reader.Close();
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }                   
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en en la Base de Datos: " + ex.Message);
                }
            }
        }

        //Constructor
        public PanelMedicamentos()
        {
            InitializeComponent();
        }

        //Actualiza la tabla con los datos al cargar el panel
        private void PanelMedicamentos_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //Refresca los datos del datagrid volviendolos a obtener de la BD
        //(Esto en caso que se agregue un nuevo dato)
        private void refresh()
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

        //Boton abrir panel agregar medicamento
        private void btnAgregarMedicamento(object sender, EventArgs e)
        {
            MostrarPanel(new panelAgregar());
            refresh();
        }

        //Boton abrir panel editar medicamento
        private void btnEditarMedicamento(object sender, EventArgs e)
        {
            int? Id = getClave_m();
            if (Id != null && ComprobarMedicamentos()==true)
            {
                MostrarPanel(new panelEditar(Id));
                refresh();
            }   
            else
            {
                MessageBox.Show("No hay medicamentos disponibles");
            }
        }

        //Boton eliminar medicamento
        private void btnEliminarMedicamento(object sender, EventArgs e)
        {
            int? Id = getClave_m();
            try
            {
                if (Id != null)
                {
                    Usuario usuario = new Usuario();
                    MedicamentoDB medicamentoDB = new MedicamentoDB();
                    medicamentoDB.eliminarMedicamento((int)Id, usuario.obtenerUsuarioActivo());
                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar " + ex.Message);
            }
        }


        #region
        //Funcion obtener clave_m
        public int? getClave_m()
        {
            try
            {
                if (ComprobarMedicamentos() == true)
                {
                    return int.Parse(dataGridView_Medicamentos.Rows[dataGridView_Medicamentos.CurrentRow.Index].Cells[0].Value.ToString());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
