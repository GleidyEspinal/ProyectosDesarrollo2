namespace Forms_Cedula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLugarNac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxOcupacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtBoxCedula = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaExpiracion = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnSubirFotoFirma = new System.Windows.Forms.Button();
            this.btnSubirFotoPerfil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.pbFotoFirma = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPÚBLICA DOMINCANA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(385, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "JUNTA CENTRAL ELECTORAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(330, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "CÉDULA DE IDENTIDAD Y ELECTORAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "FECHA DE NACIMIENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(260, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "LUGAR DE NACIMIENTO:";
            // 
            // txtBoxLugarNac
            // 
            this.txtBoxLugarNac.Location = new System.Drawing.Point(260, 149);
            this.txtBoxLugarNac.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLugarNac.Name = "txtBoxLugarNac";
            this.txtBoxLugarNac.Size = new System.Drawing.Size(531, 34);
            this.txtBoxLugarNac.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(260, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "SEXO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(260, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "NACIONALIDAD:";
            // 
            // txtBoxNacionalidad
            // 
            this.txtBoxNacionalidad.Location = new System.Drawing.Point(423, 249);
            this.txtBoxNacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNacionalidad.Name = "txtBoxNacionalidad";
            this.txtBoxNacionalidad.Size = new System.Drawing.Size(368, 34);
            this.txtBoxNacionalidad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(412, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "SANGRE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(591, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "ESTADO CIVIL:";
            // 
            // txtBoxOcupacion
            // 
            this.txtBoxOcupacion.Location = new System.Drawing.Point(401, 360);
            this.txtBoxOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxOcupacion.Name = "txtBoxOcupacion";
            this.txtBoxOcupacion.Size = new System.Drawing.Size(400, 34);
            this.txtBoxOcupacion.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(260, 366);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "OCUPACIÓN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(260, 413);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "FECHA DE EXPIRACIÓN:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(921, 160);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 29;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(513, 448);
            this.dgvUsuarios.TabIndex = 28;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtBoxCedula);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatos.Controls.Add(this.dtpFechaExpiracion);
            this.gbDatos.Controls.Add(this.cbEstadoCivil);
            this.gbDatos.Controls.Add(this.txtBoxOcupacion);
            this.gbDatos.Controls.Add(this.cbSangre);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtBoxLugarNac);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.cbSexo);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.btnSubirFotoFirma);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.txtBoxNacionalidad);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.btnSubirFotoPerfil);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.txtBoxNombre);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.pbFotoFirma);
            this.gbDatos.Controls.Add(this.pbFotoPerfil);
            this.gbDatos.Location = new System.Drawing.Point(12, 149);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(892, 459);
            this.gbDatos.TabIndex = 30;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "gbDatos";
            // 
            // txtBoxCedula
            // 
            this.txtBoxCedula.Location = new System.Drawing.Point(260, 68);
            this.txtBoxCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCedula.Name = "txtBoxCedula";
            this.txtBoxCedula.Size = new System.Drawing.Size(531, 34);
            this.txtBoxCedula.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(260, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 28);
            this.label14.TabIndex = 43;
            this.label14.Text = "NO. DE CEDULA:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(496, 201);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(326, 34);
            this.dtpFechaNacimiento.TabIndex = 42;
            // 
            // dtpFechaExpiracion
            // 
            this.dtpFechaExpiracion.Location = new System.Drawing.Point(486, 413);
            this.dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            this.dtpFechaExpiracion.Size = new System.Drawing.Size(326, 34);
            this.dtpFechaExpiracion.TabIndex = 41;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "SOLTER@",
            "CASAD@",
            "OTRO"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(734, 304);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(144, 36);
            this.cbEstadoCivil.TabIndex = 40;
            // 
            // cbSangre
            // 
            this.cbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B-",
            "B+",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbSangre.Location = new System.Drawing.Point(510, 306);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(74, 36);
            this.cbSangre.TabIndex = 39;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M",
            "OTRO"});
            this.cbSexo.Location = new System.Drawing.Point(331, 306);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(74, 36);
            this.cbSexo.TabIndex = 38;
            // 
            // btnSubirFotoFirma
            // 
            this.btnSubirFotoFirma.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubirFotoFirma.Location = new System.Drawing.Point(55, 411);
            this.btnSubirFotoFirma.Name = "btnSubirFotoFirma";
            this.btnSubirFotoFirma.Size = new System.Drawing.Size(133, 36);
            this.btnSubirFotoFirma.TabIndex = 37;
            this.btnSubirFotoFirma.Text = "SUBIR FOTO";
            this.btnSubirFotoFirma.UseVisualStyleBackColor = true;
            this.btnSubirFotoFirma.Click += new System.EventHandler(this.btnSubirFotoFirma_Click);
            // 
            // btnSubirFotoPerfil
            // 
            this.btnSubirFotoPerfil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubirFotoPerfil.Location = new System.Drawing.Point(55, 241);
            this.btnSubirFotoPerfil.Name = "btnSubirFotoPerfil";
            this.btnSubirFotoPerfil.Size = new System.Drawing.Size(133, 36);
            this.btnSubirFotoPerfil.TabIndex = 35;
            this.btnSubirFotoPerfil.Text = "SUBIR FOTO";
            this.btnSubirFotoPerfil.UseVisualStyleBackColor = true;
            this.btnSubirFotoPerfil.Click += new System.EventHandler(this.btnSubirFotoPerfil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(7, 276);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "NOMBRE:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(7, 306);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(227, 34);
            this.txtBoxNombre.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(7, 341);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 28);
            this.label12.TabIndex = 32;
            this.label12.Text = "FIRMA DIGITAL:";
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.Location = new System.Drawing.Point(7, 33);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(227, 202);
            this.pbFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoPerfil.TabIndex = 0;
            this.pbFotoPerfil.TabStop = false;
            // 
            // pbFotoFirma
            // 
            this.pbFotoFirma.Location = new System.Drawing.Point(7, 372);
            this.pbFotoFirma.Name = "pbFotoFirma";
            this.pbFotoFirma.Size = new System.Drawing.Size(227, 33);
            this.pbFotoFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoFirma.TabIndex = 36;
            this.pbFotoFirma.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms_Cedula.Properties.Resources.Coat_of_arms_of_the_Dominican_Republic_svg;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(718, 629);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 34);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(498, 629);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 34);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(272, 629);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(164, 34);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1467, 687);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtBoxLugarNac;
        private Label label6;
        private Label label7;
        private TextBox txtBoxNacionalidad;
        private Label label8;
        private Label label9;
        private TextBox txtBoxOcupacion;
        private Label label10;
        private Label label11;
        private DataGridView dgvUsuarios;
        private GroupBox gbDatos;
        private Button btnSubirFotoFirma;
        private PictureBox pbFotoFirma;
        private Button btnSubirFotoPerfil;
        private Label label13;
        private TextBox txtBoxNombre;
        private Label label12;
        private PictureBox pbFotoPerfil;
        private ComboBox cbEstadoCivil;
        private ComboBox cbSangre;
        private ComboBox cbSexo;
        private PictureBox pictureBox1;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaExpiracion;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnBorrar;
        private TextBox txtBoxCedula;
        private Label label14;
        private BindingSource usuarioBindingSource;
    }
}