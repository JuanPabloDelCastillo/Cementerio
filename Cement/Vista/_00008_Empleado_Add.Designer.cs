namespace Cement.Vista
{
    partial class _00008_Empleado_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00008_Empleado_Add));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Columnid_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalle_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAfiliado_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Empleado_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese Nombre y Apellidos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageKey = "close.png";
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(539, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSalir.Size = new System.Drawing.Size(104, 66);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
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
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(259, 15);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(361, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.dgvEmpleados);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 250);
            this.panel1.TabIndex = 3;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnid_Empleado,
            this.ColumnCodEmp,
            this.ColumnNombre_E,
            this.ColumnCalle,
            this.ColumnCalle_Numero,
            this.ColumnPiso,
            this.ColumnDepartamento,
            this.ColumTelefono,
            this.ColumnCelular,
            this.ColumnEmail,
            this.ColumnFecha_Ingreso,
            this.ColumnDni,
            this.ColumnCuil,
            this.ColumnAfiliado_Num,
            this.ColumnFoto,
            this.Columnid_Empleado_Tipo,
            this.Columnid_Usuario});
            this.dgvEmpleados.Location = new System.Drawing.Point(7, 46);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.Size = new System.Drawing.Size(613, 193);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // Columnid_Empleado
            // 
            this.Columnid_Empleado.DataPropertyName = "id_Empleado";
            this.Columnid_Empleado.HeaderText = "id_Empleado";
            this.Columnid_Empleado.Name = "Columnid_Empleado";
            this.Columnid_Empleado.ReadOnly = true;
            // 
            // ColumnCodEmp
            // 
            this.ColumnCodEmp.DataPropertyName = "CodEmp";
            this.ColumnCodEmp.HeaderText = "Codigo";
            this.ColumnCodEmp.Name = "ColumnCodEmp";
            this.ColumnCodEmp.ReadOnly = true;
            // 
            // ColumnNombre_E
            // 
            this.ColumnNombre_E.DataPropertyName = "Nombre_E";
            this.ColumnNombre_E.HeaderText = "Nombre_E";
            this.ColumnNombre_E.Name = "ColumnNombre_E";
            this.ColumnNombre_E.ReadOnly = true;
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
            // ColumTelefono
            // 
            this.ColumTelefono.DataPropertyName = "Telefono";
            this.ColumTelefono.HeaderText = "Telefono";
            this.ColumTelefono.Name = "ColumTelefono";
            this.ColumTelefono.ReadOnly = true;
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
            this.Columnid_Empleado_Tipo.Visible = false;
            // 
            // Columnid_Usuario
            // 
            this.Columnid_Usuario.DataPropertyName = "id_Usuario";
            this.Columnid_Usuario.HeaderText = "id_Usuario";
            this.Columnid_Usuario.Name = "Columnid_Usuario";
            this.Columnid_Usuario.ReadOnly = true;
            this.Columnid_Usuario.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.ImageKey = "delete.png";
            this.btnEliminar.ImageList = this.imageList1;
            this.btnEliminar.Location = new System.Drawing.Point(326, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEliminar.Size = new System.Drawing.Size(104, 66);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImageKey = "modificar.png";
            this.btnModificar.ImageList = this.imageList1;
            this.btnModificar.Location = new System.Drawing.Point(184, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnModificar.Size = new System.Drawing.Size(104, 66);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.ImageKey = "agregar.png";
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(42, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnNuevo.Size = new System.Drawing.Size(104, 66);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // _00008_Empleado_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 367);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "_00008_Empleado_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this._00008_Empleado_Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalle_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfiliado_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Empleado_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid_Usuario;
    }
}