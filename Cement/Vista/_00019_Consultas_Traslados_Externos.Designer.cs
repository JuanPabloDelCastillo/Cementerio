namespace Cement.Vista
{
    partial class _00019_Consultas_Traslados_Externos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00019_Consultas_Traslados_Externos));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodCem = new System.Windows.Forms.ComboBox();
            this.cmbTipoConstExt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Construccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Nomenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_OtroCem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodcem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuadro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_Emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTamNicho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNicho_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGaleria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha_Traslado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtroCem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Construcc.Tipo";
            // 
            // cmbCodCem
            // 
            this.cmbCodCem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodCem.FormattingEnabled = true;
            this.cmbCodCem.Location = new System.Drawing.Point(56, 14);
            this.cmbCodCem.Name = "cmbCodCem";
            this.cmbCodCem.Size = new System.Drawing.Size(93, 21);
            this.cmbCodCem.TabIndex = 52;
            this.cmbCodCem.SelectedIndexChanged += new System.EventHandler(this.cmbCodCem_SelectedIndexChanged);
            // 
            // cmbTipoConstExt
            // 
            this.cmbTipoConstExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConstExt.FormattingEnabled = true;
            this.cmbTipoConstExt.Location = new System.Drawing.Point(301, 14);
            this.cmbTipoConstExt.Name = "cmbTipoConstExt";
            this.cmbTipoConstExt.Size = new System.Drawing.Size(91, 21);
            this.cmbTipoConstExt.TabIndex = 53;
            this.cmbTipoConstExt.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConstExt_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "DESDE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDni,
            this.Columnid_Construccion,
            this.Columnid_Nomenc,
            this.Columnid_OtroCem,
            this.ColumnNombre,
            this.ColumnCodcem,
            this.ColumnNombre_C,
            this.ColumnSeccion,
            this.ColumnCuadro,
            this.ColumnZona,
            this.ColumnLote,
            this.ColumnNombre_Emp,
            this.ColumnTamNicho,
            this.ColumnNicho_Numero,
            this.ColumnGaleria,
            this.ColumnFecha_Traslado,
            this.ColumnOtroCem,
            this.ColumnObservaciones});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(828, 228);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnDni
            // 
            this.ColumnDni.DataPropertyName = "Dni";
            this.ColumnDni.HeaderText = "Dni";
            this.ColumnDni.Name = "ColumnDni";
            this.ColumnDni.ReadOnly = true;
            // 
            // Columnid_Construccion
            // 
            this.Columnid_Construccion.DataPropertyName = "id_Construccion";
            this.Columnid_Construccion.HeaderText = "id_Construccion";
            this.Columnid_Construccion.Name = "Columnid_Construccion";
            this.Columnid_Construccion.ReadOnly = true;
            this.Columnid_Construccion.Visible = false;
            // 
            // Columnid_Nomenc
            // 
            this.Columnid_Nomenc.DataPropertyName = "id_Nomenc";
            this.Columnid_Nomenc.HeaderText = "id_Nomenc";
            this.Columnid_Nomenc.Name = "Columnid_Nomenc";
            this.Columnid_Nomenc.ReadOnly = true;
            this.Columnid_Nomenc.Visible = false;
            // 
            // Columnid_OtroCem
            // 
            this.Columnid_OtroCem.DataPropertyName = "id_OtroCem";
            this.Columnid_OtroCem.HeaderText = "id_OtroCem";
            this.Columnid_OtroCem.Name = "Columnid_OtroCem";
            this.Columnid_OtroCem.ReadOnly = true;
            this.Columnid_OtroCem.Visible = false;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Nombre";
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 150;
            // 
            // ColumnCodcem
            // 
            this.ColumnCodcem.DataPropertyName = "Codcem";
            this.ColumnCodcem.HeaderText = "Cement";
            this.ColumnCodcem.Name = "ColumnCodcem";
            this.ColumnCodcem.ReadOnly = true;
            // 
            // ColumnNombre_C
            // 
            this.ColumnNombre_C.DataPropertyName = "Nombre_C";
            this.ColumnNombre_C.HeaderText = "Construccion";
            this.ColumnNombre_C.Name = "ColumnNombre_C";
            this.ColumnNombre_C.ReadOnly = true;
            // 
            // ColumnSeccion
            // 
            this.ColumnSeccion.DataPropertyName = "Seccion";
            this.ColumnSeccion.HeaderText = "Seccion";
            this.ColumnSeccion.Name = "ColumnSeccion";
            this.ColumnSeccion.ReadOnly = true;
            // 
            // ColumnCuadro
            // 
            this.ColumnCuadro.DataPropertyName = "Cuadro";
            this.ColumnCuadro.HeaderText = "Cuadro";
            this.ColumnCuadro.Name = "ColumnCuadro";
            this.ColumnCuadro.ReadOnly = true;
            // 
            // ColumnZona
            // 
            this.ColumnZona.DataPropertyName = "Zona";
            this.ColumnZona.HeaderText = "Zona";
            this.ColumnZona.Name = "ColumnZona";
            this.ColumnZona.ReadOnly = true;
            // 
            // ColumnLote
            // 
            this.ColumnLote.DataPropertyName = "Lote";
            this.ColumnLote.HeaderText = "Lote";
            this.ColumnLote.Name = "ColumnLote";
            this.ColumnLote.ReadOnly = true;
            // 
            // ColumnNombre_Emp
            // 
            this.ColumnNombre_Emp.DataPropertyName = "Nombre_Emp";
            this.ColumnNombre_Emp.HeaderText = "Empresa";
            this.ColumnNombre_Emp.Name = "ColumnNombre_Emp";
            this.ColumnNombre_Emp.ReadOnly = true;
            // 
            // ColumnTamNicho
            // 
            this.ColumnTamNicho.DataPropertyName = "TamNicho";
            this.ColumnTamNicho.HeaderText = "Tamaño Nicho";
            this.ColumnTamNicho.Name = "ColumnTamNicho";
            this.ColumnTamNicho.ReadOnly = true;
            this.ColumnTamNicho.Width = 130;
            // 
            // ColumnNicho_Numero
            // 
            this.ColumnNicho_Numero.DataPropertyName = "Nicho_Numero";
            this.ColumnNicho_Numero.HeaderText = "Nicho_Numero";
            this.ColumnNicho_Numero.Name = "ColumnNicho_Numero";
            this.ColumnNicho_Numero.ReadOnly = true;
            // 
            // ColumnGaleria
            // 
            this.ColumnGaleria.DataPropertyName = "Galeria";
            this.ColumnGaleria.HeaderText = "Galeria";
            this.ColumnGaleria.Name = "ColumnGaleria";
            this.ColumnGaleria.ReadOnly = true;
            // 
            // ColumnFecha_Traslado
            // 
            this.ColumnFecha_Traslado.DataPropertyName = "Fecha_Traslado";
            this.ColumnFecha_Traslado.HeaderText = "Fecha_Traslado";
            this.ColumnFecha_Traslado.Name = "ColumnFecha_Traslado";
            this.ColumnFecha_Traslado.ReadOnly = true;
            // 
            // ColumnOtroCem
            // 
            this.ColumnOtroCem.DataPropertyName = "OtroCem";
            this.ColumnOtroCem.HeaderText = "OtroCem";
            this.ColumnOtroCem.Name = "ColumnOtroCem";
            this.ColumnOtroCem.ReadOnly = true;
            // 
            // ColumnObservaciones
            // 
            this.ColumnObservaciones.DataPropertyName = "Observaciones";
            this.ColumnObservaciones.HeaderText = "Observaciones";
            this.ColumnObservaciones.Name = "ColumnObservaciones";
            this.ColumnObservaciones.ReadOnly = true;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.AllowDrop = true;
            this.dateTimePicker_Hasta.CustomFormat = "\'Fecha: \' dd/MM/yyyy \'Hora: \' HH:mm tt";
            this.dateTimePicker_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(378, 19);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker_Hasta.TabIndex = 47;
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.AllowDrop = true;
            this.dateTimePicker_Desde.CustomFormat = "\'Fecha: \' dd/MM/yyyy \'Hora: \' HH:mm tt";
            this.dateTimePicker_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(67, 20);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Desde.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(618, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 47);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(725, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 56);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(68, 345);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(43, 20);
            this.txtCantidad.TabIndex = 59;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCodCem);
            this.groupBox1.Controls.Add(this.cmbTipoConstExt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 45);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker_Hasta);
            this.groupBox2.Controls.Add(this.dateTimePicker_Desde);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 54);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(744, 56);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(110, 46);
            this.btnReporte.TabIndex = 63;
            this.btnReporte.Text = "Imprimir Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // _00019_Consultas_Traslados_Externos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 421);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "_00019_Consultas_Traslados_Externos";
            this.Text = "Consultas de Traslados Externos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbCodCem;
        public System.Windows.Forms.ComboBox cmbTipoConstExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Construccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Nomenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_OtroCem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodcem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuadro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_Emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTamNicho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNicho_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGaleria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha_Traslado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtroCem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReporte;
    }
}