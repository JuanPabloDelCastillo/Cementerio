namespace Cement.Vista
{
    partial class _00021_Historicos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00021_Historicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCausante = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGaleria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTamNicho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNicho_Numero = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodCem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoConst = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuadro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.Columnid_Nomenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Construccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCausante)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageKey = "close.png";
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(639, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSalir.Size = new System.Drawing.Size(104, 66);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar.png");
            this.imageList1.Images.SetKeyName(1, "close.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "modificar.png");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese Nombre y Apellidos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Location = new System.Drawing.Point(70, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 77);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.ImageKey = "delete.png";
            this.btnEditar.ImageList = this.imageList1;
            this.btnEditar.Location = new System.Drawing.Point(326, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEditar.Size = new System.Drawing.Size(104, 66);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(498, 20);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(479, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.dgvCausante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 295);
            this.panel1.TabIndex = 29;
            // 
            // dgvCausante
            // 
            this.dgvCausante.AllowUserToAddRows = false;
            this.dgvCausante.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCausante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCausante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCausante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnid_Nomenc,
            this.Columnid_Construccion});
            this.dgvCausante.Location = new System.Drawing.Point(6, 63);
            this.dgvCausante.Name = "dgvCausante";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCausante.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCausante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCausante.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCausante.Size = new System.Drawing.Size(988, 217);
            this.dgvCausante.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtGaleria);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTamNicho);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtNicho_Numero);
            this.panel3.Controls.Add(this.txtSeccion);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbCodCem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtLote);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbTipoConst);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCuadro);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtZona);
            this.panel3.Location = new System.Drawing.Point(12, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 42);
            this.panel3.TabIndex = 32;
            // 
            // txtGaleria
            // 
            this.txtGaleria.Location = new System.Drawing.Point(936, 9);
            this.txtGaleria.MaxLength = 2;
            this.txtGaleria.Name = "txtGaleria";
            this.txtGaleria.Size = new System.Drawing.Size(50, 20);
            this.txtGaleria.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(897, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Galeria";
            // 
            // txtTamNicho
            // 
            this.txtTamNicho.Location = new System.Drawing.Point(855, 10);
            this.txtTamNicho.MaxLength = 2;
            this.txtTamNicho.Name = "txtTamNicho";
            this.txtTamNicho.Size = new System.Drawing.Size(43, 20);
            this.txtTamNicho.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tam.Nicho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(702, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nicho Num.";
            // 
            // txtNicho_Numero
            // 
            this.txtNicho_Numero.Location = new System.Drawing.Point(764, 10);
            this.txtNicho_Numero.MaxLength = 2;
            this.txtNicho_Numero.Name = "txtNicho_Numero";
            this.txtNicho_Numero.Size = new System.Drawing.Size(34, 20);
            this.txtNicho_Numero.TabIndex = 26;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(471, 10);
            this.txtSeccion.MaxLength = 2;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(31, 20);
            this.txtSeccion.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Seccion";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(-4, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Búsqueda por Nomenc.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Construcc.Tipo";
            // 
            // cmbCodCem
            // 
            this.cmbCodCem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodCem.FormattingEnabled = true;
            this.cmbCodCem.Location = new System.Drawing.Point(187, 10);
            this.cmbCodCem.Name = "cmbCodCem";
            this.cmbCodCem.Size = new System.Drawing.Size(70, 21);
            this.cmbCodCem.TabIndex = 15;
            this.cmbCodCem.SelectedIndexChanged += new System.EventHandler(this.cmbCodCem_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lote";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(669, 10);
            this.txtLote.MaxLength = 3;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(34, 20);
            this.txtLote.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Zona";
            // 
            // cmbTipoConst
            // 
            this.cmbTipoConst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConst.FormattingEnabled = true;
            this.cmbTipoConst.Location = new System.Drawing.Point(336, 10);
            this.cmbTipoConst.Name = "cmbTipoConst";
            this.cmbTipoConst.Size = new System.Drawing.Size(92, 21);
            this.cmbTipoConst.TabIndex = 16;
            this.cmbTipoConst.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cuadro";
            // 
            // txtCuadro
            // 
            this.txtCuadro.Location = new System.Drawing.Point(540, 10);
            this.txtCuadro.MaxLength = 2;
            this.txtCuadro.Name = "txtCuadro";
            this.txtCuadro.Size = new System.Drawing.Size(34, 20);
            this.txtCuadro.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cement";
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(606, 10);
            this.txtZona.MaxLength = 2;
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(34, 20);
            this.txtZona.TabIndex = 18;
            // 
            // Columnid_Nomenc
            // 
            this.Columnid_Nomenc.DataPropertyName = "id_Nomenc";
            this.Columnid_Nomenc.HeaderText = "id_Nomenc";
            this.Columnid_Nomenc.Name = "Columnid_Nomenc";
            this.Columnid_Nomenc.Visible = false;
            // 
            // Columnid_Construccion
            // 
            this.Columnid_Construccion.DataPropertyName = "id_Construccion";
            this.Columnid_Construccion.HeaderText = "id_Construccion";
            this.Columnid_Construccion.Name = "Columnid_Construccion";
            this.Columnid_Construccion.Visible = false;
            // 
            // _00021_Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "_00021_Historicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_00021_Historicos";
            this.Load += new System.EventHandler(this._00021_Historicos_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCausante)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvCausante;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtGaleria;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTamNicho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNicho_Numero;
        public System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbCodCem;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbTipoConst;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCuadro;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Nomenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Construccion;
    }
}