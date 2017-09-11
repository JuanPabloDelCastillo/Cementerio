namespace Cement.Vista
{
    partial class _00006_Empleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUSUARIOS = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalle_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAfiliado_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Empleado_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvUSUARIOS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Lista ]";
            // 
            // dgvUSUARIOS
            // 
            this.dgvUSUARIOS.AllowUserToAddRows = false;
            this.dgvUSUARIOS.AllowUserToDeleteRows = false;
            this.dgvUSUARIOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUSUARIOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUSUARIOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.ColumnNombre_E,
            this.ColumnCalle,
            this.ColumnCalle_Numero,
            this.ColumnPiso,
            this.ColumnDepartamento,
            this.ColumnTelefono,
            this.ColumnCelular,
            this.ColumnEmail,
            this.ColumnFecha_Ingreso,
            this.ColumnDni,
            this.ColumnCuil,
            this.ColumnAfiliado_Num,
            this.ColumnTurno,
            this.ColumnFoto,
            this.Columnid_Empleado_Tipo,
            this.ColumnCODIGO,
            this.ColumnNOMBRE,
            this.ColumnTIPO});
            this.dgvUSUARIOS.Location = new System.Drawing.Point(7, 19);
            this.dgvUSUARIOS.Name = "dgvUSUARIOS";
            this.dgvUSUARIOS.ReadOnly = true;
            this.dgvUSUARIOS.Size = new System.Drawing.Size(462, 240);
            this.dgvUSUARIOS.TabIndex = 0;
            this.dgvUSUARIOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellDoubleClick);
            this.dgvUSUARIOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmpleado_KeyDown);
            // 
            // id_Empleado
            // 
            this.id_Empleado.DataPropertyName = "id_Empleado";
            this.id_Empleado.HeaderText = "id_Empleado";
            this.id_Empleado.Name = "id_Empleado";
            this.id_Empleado.ReadOnly = true;
            this.id_Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_Empleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNombre_E
            // 
            this.ColumnNombre_E.DataPropertyName = "Nombre_E";
            this.ColumnNombre_E.HeaderText = "Nombre_E";
            this.ColumnNombre_E.Name = "ColumnNombre_E";
            this.ColumnNombre_E.ReadOnly = true;
            this.ColumnNombre_E.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNombre_E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnNombre_E.Width = 250;
            // 
            // ColumnCalle
            // 
            this.ColumnCalle.DataPropertyName = "Calle";
            this.ColumnCalle.HeaderText = "Calle";
            this.ColumnCalle.Name = "ColumnCalle";
            this.ColumnCalle.ReadOnly = true;
            // 
            // ColumnCalle_Numero
            // 
            this.ColumnCalle_Numero.DataPropertyName = "Calle_Numero";
            this.ColumnCalle_Numero.HeaderText = "Calle_Numero";
            this.ColumnCalle_Numero.Name = "ColumnCalle_Numero";
            this.ColumnCalle_Numero.ReadOnly = true;
            // 
            // ColumnPiso
            // 
            this.ColumnPiso.DataPropertyName = "Piso";
            this.ColumnPiso.HeaderText = "Piso";
            this.ColumnPiso.Name = "ColumnPiso";
            this.ColumnPiso.ReadOnly = true;
            // 
            // ColumnDepartamento
            // 
            this.ColumnDepartamento.DataPropertyName = "Departamento";
            this.ColumnDepartamento.HeaderText = "Departamento";
            this.ColumnDepartamento.Name = "ColumnDepartamento";
            this.ColumnDepartamento.ReadOnly = true;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.DataPropertyName = "Telefono";
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.ReadOnly = true;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.DataPropertyName = "Celular";
            this.ColumnCelular.HeaderText = "Celular";
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "Email";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnFecha_Ingreso
            // 
            this.ColumnFecha_Ingreso.DataPropertyName = "Fecha_Ingreso";
            this.ColumnFecha_Ingreso.HeaderText = "Fecha_Ingreso";
            this.ColumnFecha_Ingreso.Name = "ColumnFecha_Ingreso";
            this.ColumnFecha_Ingreso.ReadOnly = true;
            // 
            // ColumnDni
            // 
            this.ColumnDni.DataPropertyName = "Dni";
            this.ColumnDni.HeaderText = "Dni";
            this.ColumnDni.Name = "ColumnDni";
            this.ColumnDni.ReadOnly = true;
            // 
            // ColumnCuil
            // 
            this.ColumnCuil.DataPropertyName = "Cuil";
            this.ColumnCuil.HeaderText = "Cuil";
            this.ColumnCuil.Name = "ColumnCuil";
            this.ColumnCuil.ReadOnly = true;
            // 
            // ColumnAfiliado_Num
            // 
            this.ColumnAfiliado_Num.DataPropertyName = "Afiliado_Num";
            this.ColumnAfiliado_Num.HeaderText = "Afiliado_Num";
            this.ColumnAfiliado_Num.Name = "ColumnAfiliado_Num";
            this.ColumnAfiliado_Num.ReadOnly = true;
            // 
            // ColumnTurno
            // 
            this.ColumnTurno.HeaderText = "Turno";
            this.ColumnTurno.Name = "ColumnTurno";
            this.ColumnTurno.ReadOnly = true;
            // 
            // ColumnFoto
            // 
            this.ColumnFoto.DataPropertyName = "Foto";
            this.ColumnFoto.HeaderText = "Foto";
            this.ColumnFoto.Name = "ColumnFoto";
            this.ColumnFoto.ReadOnly = true;
            // 
            // Columnid_Empleado_Tipo
            // 
            this.Columnid_Empleado_Tipo.DataPropertyName = "id_Empleado_Tipo";
            this.Columnid_Empleado_Tipo.HeaderText = "id_Empleado_Tipo";
            this.Columnid_Empleado_Tipo.Name = "Columnid_Empleado_Tipo";
            this.Columnid_Empleado_Tipo.ReadOnly = true;
            // 
            // ColumnCODIGO
            // 
            this.ColumnCODIGO.DataPropertyName = "CODIGO";
            this.ColumnCODIGO.HeaderText = "CODIGO";
            this.ColumnCODIGO.Name = "ColumnCODIGO";
            this.ColumnCODIGO.ReadOnly = true;
            // 
            // ColumnNOMBRE
            // 
            this.ColumnNOMBRE.DataPropertyName = "NOMBRE";
            this.ColumnNOMBRE.HeaderText = "NOMBRE";
            this.ColumnNOMBRE.Name = "ColumnNOMBRE";
            this.ColumnNOMBRE.ReadOnly = true;
            // 
            // ColumnTIPO
            // 
            this.ColumnTIPO.DataPropertyName = "TIPO";
            this.ColumnTIPO.HeaderText = "TIPO";
            this.ColumnTIPO.Name = "ColumnTIPO";
            this.ColumnTIPO.ReadOnly = true;
            // 
            // _00006_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "_00006_Empleado";
            this.Text = "Empleados Registrados";
            this.Load += new System.EventHandler(this._00006_Empleado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvUSUARIOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalle_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfiliado_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Empleado_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTIPO;
    }
}