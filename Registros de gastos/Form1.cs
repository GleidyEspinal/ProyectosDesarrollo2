using Newtonsoft.Json;
using Registros_de_gastos.Modelos;
using System.Text;

namespace Registros_de_gastos
{
    public partial class FormTransacciones : Form
    {
        int id = 0;
        public bool agregandoTransaccion { get; set; } = true;
        public int obtenerSiguienteID()
        {
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transacciones.json";
            var listaDeTransacciones = new List<Transaccion>();
            if (File.Exists(pathfile))
            {
                var json = File.ReadAllText(pathfile);
                listaDeTransacciones = JsonConvert.DeserializeObject<List<Transaccion>>(json);
            }
            if (listaDeTransacciones.Count>0)   
                return listaDeTransacciones.Max(x=>x.ID) + 1;
            return 1;
        }
        public FormTransacciones()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
            actualizarTransacciones();
            cbConcepto.DataSource = obtenerConceptos().FindAll(x => x.Visibilidad == true);
            cbConcepto.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
            cbCategoria.DataSource = obtenerCategorias().FindAll(x => x.Visibilidad == true);
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var formCategorias = new FormCategorias();
            formCategorias.Show();
            this.Hide();

        }


        private void btnAgregarConcepto_Click(object sender, EventArgs e)
        {
            var formConceptos = new FormConceptos();
            formConceptos.Show();
            this.Hide();
        }
       

       
        void limpiarPanel()
        {
            dtpFechaDeRealizacion.Value = DateTime.Now;
            if(cbCategoria.Items.Count > 0) cbCategoria.SelectedIndex = 0;
            if (cbConcepto.Items.Count > 0) cbConcepto.SelectedIndex = 0;
            txtMonto.Text = string.Empty;
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
                return new List<Categoria>();
            }

            return listaDeCategorias;
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

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.DataSource = obtenerCategorias().FindAll(x => x.Visibilidad == true);
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
        }

        private void cbConcepto_Click(object sender, EventArgs e)
        {
            cbConcepto.DataSource = obtenerConceptos().FindAll(x => x.Visibilidad == true);
            cbConcepto.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Nombre";
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarTransaccion();
        }

        private void guardarTransaccion()
        {
            try
            {
                var json = string.Empty;
                var listaDeTransacciones = new List<Transaccion>();
                var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transacciones.json";

                if (File.Exists(pathfile))
                {
                    json = File.ReadAllText(pathfile, Encoding.UTF8);
                    listaDeTransacciones = JsonConvert.DeserializeObject<List<Transaccion>>(json);

                    var transaccionExistente = 0;
                    if (listaDeTransacciones != null)
                    {
                        transaccionExistente = listaDeTransacciones.Count(X => X.ID == id);
                    }

                    if (listaDeTransacciones == null)
                    {
                        listaDeTransacciones = new List<Transaccion>();
                    }

                    if ( transaccionExistente > 0)
                    {
                        agregandoTransaccion = false;
                    }
                }

                var transaccion = new Transaccion();
                

                if (agregandoTransaccion)// Agregando una nueva transaccion
                {
                    transaccion.FechaDeRealizacion = dtpFechaDeRealizacion.Value;
                    transaccion.Categoria = cbCategoria.Text;
                    transaccion.Concepto = cbConcepto.Text;
                    transaccion.Monto = Convert.ToInt32(txtMonto.Text);
                    transaccion.ID = obtenerSiguienteID();
                        
                }
                else //Modificando una transaccion existente
                {
                    transaccion = listaDeTransacciones.FirstOrDefault(x => x.ID == id);
                    var fechaCreacion = transaccion.FechaDeRealizacion;
                    listaDeTransacciones.Remove(transaccion);
                    transaccion.FechaModificacion = DateTime.Now;
                    transaccion.Categoria = cbCategoria.Text;
                    transaccion.Concepto = cbConcepto.Text;
                    transaccion.Monto = Convert.ToInt32(txtMonto.Text);
                    transaccion.FechaDeRealizacion = fechaCreacion;
                    transaccion.ID = id;
                    agregandoTransaccion = true;
                }


                listaDeTransacciones.Add(transaccion);

                json = JsonConvert.SerializeObject(listaDeTransacciones);
                var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();

                MessageBox.Show("Transaccion registrada", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarPanel();

                actualizarTransacciones();
                agregandoTransaccion = true;
                id = 0;
            }

            catch (Exception e)
            {
                if (txtMonto.Text.ToString() == "")
                {
                    MessageBox.Show("Favor complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El monto no esta en el formato correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                limpiarPanel();
            }

        }

        private void actualizarTransacciones()
        {
            dgvTransacciones.DataSource = obtenerTrasacciones();
            dgvTransacciones.Columns["ID"].Visible = false;
        }

        private List<Transaccion> obtenerTrasacciones()
        {
            var listaDeTransacciones = new List<Transaccion>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transacciones.json";

            if (File.Exists(pathfile))
            {
                var json = File.ReadAllText(pathfile);
                listaDeTransacciones = JsonConvert.DeserializeObject<List<Transaccion>>(json);
            }

            if (listaDeTransacciones == null)
            {
                listaDeTransacciones = new List<Transaccion>();
            }

            return listaDeTransacciones;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transacciones.json";
            var json = File.ReadAllText(pathfile);
            var listaDeTransacciones = JsonConvert.DeserializeObject<List<Transaccion>>(json);

            DataGridViewRow fila = dgvTransacciones.SelectedRows[0];
            listaDeTransacciones.RemoveAt(fila.Index);

            json = JsonConvert.SerializeObject(listaDeTransacciones);
            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            actualizarTransacciones();
            limpiarPanel();
            btnBorrar.Enabled = false;
            

        }
        private void dgvTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            if (rowIndex > -1)
            {
                btnBorrar.Enabled = true;
                List<Transaccion> listaDeTransacciones = obtenerTrasacciones();
                llenarForm(listaDeTransacciones[rowIndex]);
            }

        }

        private void llenarForm(Transaccion transaccion)
        {
            dtpFechaDeRealizacion.Value = transaccion.FechaDeRealizacion;
            cbCategoria.Text = transaccion.Categoria;
            cbConcepto.Text = transaccion.Concepto;
            txtMonto.Text = Convert.ToString(transaccion.Monto);
            id = transaccion.ID;
        }

        private void FormTransacciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formConceptos = new FormConceptos();
            var formCategorias = new FormCategorias();
            var formTransacciones = new FormTransacciones();
            formConceptos.Close();
            formCategorias.Close();
            formTransacciones.Close();
        }

        //private void FormTransacciones_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    var formConceptos = new FormConceptos();
        //    var formCategorias = new FormCategorias();
        //    var formTransacciones = new FormTransacciones();
        //    formConceptos.Close();
        //    formCategorias.Close();
        //    formTransacciones.Close();

        //}


    }
}