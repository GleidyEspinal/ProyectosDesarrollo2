
using Forms_Cedula.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace Forms_Cedula
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            btnBorrar.Enabled = false;
            actualizarCiudadanos();
        }
        public bool agregando { get; set; } = true;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCiudadano();
        }

        private void guardarCiudadano()
        {
            var json = string.Empty;
            var listaDeCiudadanos = new List<Ciudadano>();
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Ciudadanos.json";

            if (File.Exists(pathfile))
            {
                json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);

            }
                var CiudadanoExistente = 0;

                if (listaDeCiudadanos != null)
                {
                    CiudadanoExistente = listaDeCiudadanos.Count(x => x.Cedula.Trim() == txtBoxCedula.Text.Trim());

                }
                else
                {
                    listaDeCiudadanos = new List<Ciudadano>();
                }

                if (CiudadanoExistente > 0)
                {
                    MessageBox.Show("Usuario actualizado", "Junta Central Electoral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Este ciudadano ya esta registrado", "Junta Central Electoral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    agregando = false;
                }

                var ciudadano = new Ciudadano();
                if (agregando)
                {
                    ciudadano = new Ciudadano()
                    {
                        NombreUsuario = txtBoxNombre.Text,
                        LugarNacimiento = txtBoxLugarNac.Text,
                        Cedula = txtBoxCedula.Text,
                        FechaNacimiento = dtpFechaNacimiento.Value,
                        Nacionalidad = txtBoxNacionalidad.Text,
                        Sexo = cbSexo.Text,
                        Sangre = cbSangre.Text,
                        EstadoCivil = cbEstadoCivil.Text,
                        Ocupacion = txtBoxOcupacion.Text,
                        FechaExpiracion = dtpFechaExpiracion.Value,
                        PersonaImagenTexto = pbFotoPerfil.ImageLocation,
                        FirmaImagenTexto = pbFotoFirma.ImageLocation,
                        FechaDeCreacion = DateTime.Now,

                    };
                MessageBox.Show("Usuario agregado", "Junta Central Electoral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else
                {
                ciudadano = listaDeCiudadanos.FirstOrDefault(x => x.Cedula.Trim() == txtBoxCedula.Text.Trim());

                    listaDeCiudadanos.Remove(ciudadano);

                    ciudadano = new Ciudadano()
                    {
                        NombreUsuario = txtBoxNombre.Text,
                        LugarNacimiento = txtBoxLugarNac.Text,
                        Cedula = txtBoxCedula.Text,
                        FechaNacimiento = dtpFechaNacimiento.Value,
                        Nacionalidad = txtBoxNacionalidad.Text,
                        Sexo = cbSexo.Text,
                        Sangre = cbSangre.Text,
                        EstadoCivil = cbEstadoCivil.Text,
                        Ocupacion = txtBoxOcupacion.Text,
                        FechaExpiracion = dtpFechaExpiracion.Value,
                        PersonaImagenTexto = pbFotoPerfil.ImageLocation,
                        FirmaImagenTexto = pbFotoFirma.ImageLocation,
                        FechaDeModificacion = DateTime.Now,

                    };
                    //MessageBox.Show("Usuario actualizado", "Junta Central Electoral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            listaDeCiudadanos.Add(ciudadano);

                json = JsonConvert.SerializeObject(listaDeCiudadanos);

                var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();


                LimpiarControles();
                actualizarCiudadanos();
                agregando = true;
           

        }

        private void actualizarCiudadanos()
        {
            dgvUsuarios.DataSource = obtenerCiudadanos();
        }

        private List<Ciudadano> obtenerCiudadanos()
        {
            //dgvUsuarios.DataSource = null;
            //dgvUsuarios.DataSource = Usuarios;

            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Ciudadanos.json";
            var listaDeCiudadanos = new List<Ciudadano>();

            if (File.Exists(pathfile))
            {
                var json = File.ReadAllText(pathfile, Encoding.UTF8);
                listaDeCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            }
            if (listaDeCiudadanos == null)
            {
                listaDeCiudadanos = new List<Ciudadano>();
            }
            return listaDeCiudadanos;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            pbFotoPerfil.Image = null;
            pbFotoFirma.Image = null;
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaExpiracion.Value = DateTime.Today;

            foreach (Control X in gbDatos.Controls) 
            {
                if (X is TextBox or ComboBox)
                { 
                    X.Text = string.Empty;
                }
            }
            agregando = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)

        {
            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Ciudadanos.json";
            var json = File.ReadAllText(pathfile, Encoding.UTF8);
            var listaDeCiudadano = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
          
            DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];

            listaDeCiudadano.RemoveAt(fila.Index);

            json = JsonConvert.SerializeObject(listaDeCiudadano);

            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            LimpiarControles();
            actualizarCiudadanos();
            btnBorrar.Enabled = false;

        }

        private void btnSubirFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoPerfil.ImageLocation = ofd.FileName;
            }

        }

        private void btnSubirFotoFirma_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoFirma.ImageLocation = ofd.FileName;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            agregando = false;
            var rowIndex = e.RowIndex;
            if (rowIndex > -1) 
            {
                btnBorrar.Enabled = true;
                List<Ciudadano> ciudadano = obtenerCiudadanos();
                llenarForm(ciudadano[rowIndex]);
            }

        }

        private void llenarForm(Ciudadano ciudadano)
        {
            txtBoxNombre.Text = ciudadano.NombreUsuario;
            txtBoxLugarNac.Text = ciudadano.LugarNacimiento;
            txtBoxCedula.Text = ciudadano.Cedula;
            dtpFechaNacimiento.Value = ciudadano.FechaNacimiento;
            txtBoxNacionalidad.Text = ciudadano.Nacionalidad;
            cbSexo.Text = ciudadano.Sexo;
            cbSangre.Text = ciudadano.Sangre;
            cbEstadoCivil.Text = ciudadano.EstadoCivil;
            txtBoxOcupacion.Text = ciudadano.Ocupacion;
            dtpFechaExpiracion.Value = ciudadano.FechaExpiracion;
            pbFotoPerfil.ImageLocation = ciudadano.PersonaImagenTexto;
            pbFotoFirma.ImageLocation = ciudadano.FirmaImagenTexto;
                      
        }

        
    }

      
    }