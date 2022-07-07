namespace Registros_de_gastos
{
    partial class FormTransacciones
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarConcepto = new System.Windows.Forms.Button();
            this.gbgastos = new System.Windows.Forms.GroupBox();
            this.dtpFechaDeRealizacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.gbgastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de transacciones";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(109, 137);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(250, 28);
            this.cbCategoria.TabIndex = 1;
            this.cbCategoria.Click += new System.EventHandler(this.cbCategoria_Click);
            // 
            // cbConcepto
            // 
            this.cbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(109, 181);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(250, 28);
            this.cbConcepto.TabIndex = 2;
            this.cbConcepto.Click += new System.EventHandler(this.cbConcepto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(109, 226);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(290, 27);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Concepto:";
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransacciones.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Location = new System.Drawing.Point(12, 388);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 51;
            this.dgvTransacciones.RowTemplate.Height = 29;
            this.dgvTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacciones.Size = new System.Drawing.Size(884, 264);
            this.dgvTransacciones.TabIndex = 7;
            this.dgvTransacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransacciones_CellClick);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(372, 137);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(27, 28);
            this.btnAgregarCategoria.TabIndex = 11;
            this.btnAgregarCategoria.Text = "+";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.Location = new System.Drawing.Point(372, 181);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(27, 28);
            this.btnAgregarConcepto.TabIndex = 12;
            this.btnAgregarConcepto.Text = "+";
            this.btnAgregarConcepto.UseVisualStyleBackColor = true;
            this.btnAgregarConcepto.Click += new System.EventHandler(this.btnAgregarConcepto_Click);
            // 
            // gbgastos
            // 
            this.gbgastos.Controls.Add(this.dtpFechaDeRealizacion);
            this.gbgastos.Controls.Add(this.label7);
            this.gbgastos.Controls.Add(this.label6);
            this.gbgastos.Controls.Add(this.label1);
            this.gbgastos.Controls.Add(this.btnAgregarCategoria);
            this.gbgastos.Controls.Add(this.btnAgregarConcepto);
            this.gbgastos.Controls.Add(this.txtMonto);
            this.gbgastos.Controls.Add(this.label3);
            this.gbgastos.Controls.Add(this.label2);
            this.gbgastos.Controls.Add(this.cbConcepto);
            this.gbgastos.Controls.Add(this.cbCategoria);
            this.gbgastos.Location = new System.Drawing.Point(245, 29);
            this.gbgastos.Name = "gbgastos";
            this.gbgastos.Size = new System.Drawing.Size(425, 273);
            this.gbgastos.TabIndex = 15;
            this.gbgastos.TabStop = false;
            this.gbgastos.Text = "Inicio";
            // 
            // dtpFechaDeRealizacion
            // 
            this.dtpFechaDeRealizacion.Location = new System.Drawing.Point(109, 89);
            this.dtpFechaDeRealizacion.Name = "dtpFechaDeRealizacion";
            this.dtpFechaDeRealizacion.Size = new System.Drawing.Size(250, 27);
            this.dtpFechaDeRealizacion.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Monto:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(534, 329);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 37);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(404, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 37);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(271, 330);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 37);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 664);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.gbgastos);
            this.Name = "FormTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransacciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransacciones_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.gbgastos.ResumeLayout(false);
            this.gbgastos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox cbCategoria;
        private ComboBox cbConcepto;
        private TextBox txtMonto;
        private Label label2;
        private Label label3;
        private DataGridView dgvTransacciones;
        private Button btnAgregarCategoria;
        private Button btnAgregarConcepto;
        private GroupBox gbgastos;
        private DateTimePicker dtpFechaDeRealizacion;
        private Label label7;
        private Label label6;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnBorrar;
    }
}