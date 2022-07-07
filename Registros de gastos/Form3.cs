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
    public partial class FormConceptos : Form
    {
        private bool agregandoConcepto { get; set; } = true;

        public FormConceptos()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
            actualizarConceptos();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardadConcepto();
        }

        private void guardadConcepto()
        {
            var json = string.Empty;
            var listaDeConceptos = new List<Concepto>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";

            if (File.Exists(pathfile))
            {
                json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeConceptos = JsonConvert.DeserializeObject<List<Concepto>>(json);

                var conceptoExistente = 0;

                if (listaDeConceptos != null)
                {
                    conceptoExistente = listaDeConceptos.Count(X=>X.Nombre.ToString().ToLower().Trim()==txtNombre.Text.ToString().ToLower().Trim());
                }
                else
                {
                    listaDeConceptos = new List<Concepto>();
                }
                
                if (conceptoExistente != 0)
                {
                    agregandoConcepto = false;
                }


            }

            var concepto = new Concepto();
            if (agregandoConcepto)//Creando un nuevo concepto
            {
                concepto.Nombre = txtNombre.Text;
                concepto.Descripcion = txtDescripcion.Text;
                concepto.Visibilidad = chbVisibilidad.Checked;
                concepto.FechaDeCreacion = DateTime.Now;

            }
            else//Editando un nuevo concepto
            {
                concepto = listaDeConceptos.FirstOrDefault(X=>X.Nombre.ToString().ToLower().Trim() == txtNombre.Text.ToString().ToLower().Trim());
                listaDeConceptos.Remove(concepto);

                concepto.Nombre = txtNombre.Text;
                concepto.Descripcion = txtDescripcion.Text;
                concepto.Visibilidad = chbVisibilidad.Checked;
                concepto.FechaDeModificacion = DateTime.Now;

            }

            listaDeConceptos.Add(concepto);

            json = JsonConvert.SerializeObject(listaDeConceptos);
            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Concepto Registrado","INTEC", MessageBoxButtons.OK,MessageBoxIcon.Information);
            limpiarPanel();

            actualizarConceptos();
        }

       

        private List<Concepto> obtenerConceptos()
        {
            var listaDeConceptos = new List<Concepto>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";


            if (File.Exists(pathfile))
            {
                var json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeConceptos = JsonConvert.DeserializeObject<List<Concepto>>(json);
            }

            if (listaDeConceptos == null)
            {
                listaDeConceptos = new List<Concepto>();
            }
                
            return listaDeConceptos;
        }

        private void actualizarConceptos()
        {
            dgvConceptos.DataSource = obtenerConceptos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
            var json = File.ReadAllText(pathfile, Encoding.UTF8);
            var listaDeConceptos = JsonConvert.DeserializeObject<List<Concepto>>(json);

            DataGridViewRow fila = dgvConceptos.SelectedRows[0];
            listaDeConceptos.RemoveAt(fila.Index);

            json = JsonConvert.SerializeObject(listaDeConceptos);
            var sw = new StreamWriter(pathfile,false,Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            actualizarConceptos();
            limpiarPanel();

            btnBorrar.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }

        private void limpiarPanel()
        {
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            chbVisibilidad.Checked = false;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicio = true;
            this.Close();
        }

        bool inicio = true;
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            inicio = false;
            var formCategorias = new FormCategorias();
            formCategorias.Show();
            this.Close();
        }
        private void dgvConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                btnBorrar.Enabled = true;
                List<Concepto> concepto = obtenerConceptos();
                llenarForm(concepto[rowIndex]);
            }
        }
        private void llenarForm(Concepto concepto)
        {
            txtNombre.Text = concepto.Nombre;
            txtDescripcion.Text = concepto.Descripcion;
            chbVisibilidad.Checked = concepto.Visibilidad;

        }

        private void FormConceptos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inicio)
            {
                foreach(Form f in Application.OpenForms)
                {
                   if( f.GetType() == typeof(FormTransacciones))
                    {
                        f.Show();
                        break;  
                    }

                }
            }
            
        }
    }


    
}
