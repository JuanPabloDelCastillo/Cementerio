namespace Cement.Vista
{
    partial class _00020_Consultas_Traslados_Dni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00020_Consultas_Traslados_Dni));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Dni = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvConsultaExt = new System.Windows.Forms.DataGridView();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaExt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(774, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 64);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(360, 62);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(23, 13);
            this.Dni.TabIndex = 64;
            this.Dni.Text = "Dni";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(778, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 64);
            this.btnSalir.TabIndex = 63;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsultaExt
            // 
            this.dgvConsultaExt.AllowUserToAddRows = false;
            this.dgvConsultaExt.AllowUserToDeleteRows = false;
            this.dgvConsultaExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaExt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDni});
            this.dgvConsultaExt.Location = new System.Drawing.Point(24, 120);
            this.dgvConsultaExt.Name = "dgvConsultaExt";
            this.dgvConsultaExt.ReadOnly = true;
            this.dgvConsultaExt.Size = new System.Drawing.Size(749, 242);
            this.dgvConsultaExt.TabIndex = 60;
            // 
            // ColumnDni
            // 
            this.ColumnDni.DataPropertyName = "Dni";
            this.ColumnDni.HeaderText = "Dni";
            this.ColumnDni.Name = "ColumnDni";
            this.ColumnDni.ReadOnly = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(383, 59);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(65, 20);
            this.txtDni.TabIndex = 73;
            // 
            // _00020_Consultas_Traslados_Dni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 494);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Dni);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsultaExt);
            this.Name = "_00020_Consultas_Traslados_Dni";
            this.Text = "Consultas por Dni";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvConsultaExt;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
    }
}