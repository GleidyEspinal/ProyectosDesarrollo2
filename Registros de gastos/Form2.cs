using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Registros_de_gastos.Modelos;

namespace Registros_de_gastos
{
    public partial class FormCategorias : Form
    {
        public bool agregandoCategoria { get; set; } = true;
        

        public FormCategorias()
        {
            InitializeComponent();
            actualizarCategorias();
            btnBorrar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCategoria();
        }

        private void guardarCategoria()
        {
            var json = string.Empty;
            var listaDeCategorias = new List<Categoria>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorias.json";

            if (File.Exists(pathfile))
            {
                json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeCategorias = JsonConvert.DeserializeObject<List<Categoria>>(json);

                var categoriaExistente = 0;

                if (listaDeCategorias != null)
                {
                    categoriaExistente = listaDeCategorias.Count(x => x.Nombre.ToString().ToLower().Trim() == txtNombre.Text.ToLower().Trim());

                }
                else
                {
                    listaDeCategorias = new List<Categoria>();
                }
                
                if (categoriaExistente != 0)
                {
                    agregandoCategoria = false;
                }
            }

           
            var categoria = new Categoria();
            if (agregandoCategoria) // Agregando una nueva categoria
            {
                categoria.Nombre = txtNombre.Text;
                categoria.Descripcion = txtDescripcion.Text;
                categoria.Visibilidad = chbVisibilidad.Checked;
                categoria.FechaDeCreacion = DateTime.Now;
                
                
            }
            else //Modificando una categoria existente
            {
                categoria = listaDeCategorias.FirstOrDefault(x => x.Nombre.ToString().ToLower().Trim() == txtNombre.Text.ToLower().Trim());

                listaDeCategorias.Remove(categoria);
                categoria.Nombre = txtNombre.Text;
                categoria.Descripcion= txtDescripcion.Text;
                categoria.Visibilidad = chbVisibilidad.Checked;
                categoria.FechaDeModificacion = DateTime.Now;
               
            }

            listaDeCategorias.Add(categoria);

            

            json = JsonConvert.SerializeObject(listaDeCategorias);

            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Categoria registrada", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarPanel();


            actualizarCategorias();
        }

        private List<Categoria> obtenerCategorias()
        {
            var listaDeCategorias = new List<Categoria>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorias.json";

            if (File.Exists(pathfile))
            {
                var json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeCategorias = JsonConvert.DeserializeObject<List<Categoria>>(json);

            }
            if (listaDeCategorias == null)
            {
                //return
                listaDeCategorias = new List<Categoria>();
            }

            return listaDeCategorias;
        }
        
        private void actualizarCategorias()
        {
            dgvCategorias.DataSource = obtenerCategorias();
        }

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorias.json";

            var json = File.ReadAllText(pathfile, Encoding.UTF8);

            var listaDeCategorias = JsonConvert.DeserializeObject<List<Categoria>>(json);

            DataGridViewRow fila = this.dgvCategorias.SelectedRows[0];

            listaDeCategorias.RemoveAt(fila.Index);

            json = JsonConvert.SerializeObject(listaDeCategorias);

            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();


            actualizarCategorias();
            limpiarPanel();
            btnBorrar.Enabled = false;
        }
   

        private void limpiarPanel()
        {
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            chbVisibilidad.Checked = false;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e) //Modificar catergorias
        {

            var rowIndex = e.RowIndex;

            if (rowIndex > -1)
            {
                btnBorrar.Enabled = true;
                List<Categoria> categoria = obtenerCategorias();

                llenarForm(categoria[rowIndex]);
            }

        }

        private void llenarForm(Categoria categoria)
        {
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
            chbVisibilidad.Checked = categoria.Visibilidad;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }

        

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            var formConceptos = new FormConceptos();
            formConceptos.Show();
            inicio = false;
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicio = true; 
            this.Close();
        }
        bool inicio = true; //variable que le dice al sistema si quiero ir a transacciones
        private void FormCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inicio)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(FormTransacciones))
                    {
                        f.Show();
                        break;
                    }
                }
            }
            
        }

        //private void FormCategorias_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    var formTracciones = new FormTransacciones();
        //    formTracciones.Show();
        //}
    }


   // MessageBox.Show("No puede agregar una categoria vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
}

