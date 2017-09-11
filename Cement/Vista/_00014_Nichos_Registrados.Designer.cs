namespace Cement.Vista
{
    partial class _00014_Nichos_Registrados
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
            this.dgvNichos = new System.Windows.Forms.DataGridView();
            this.ColumnNumeroNicho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTamanoNicho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGaleria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoNichos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNichos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNichos
            // 
            this.dgvNichos.AllowUserToAddRows = false;
            this.dgvNichos.AllowUserToDeleteRows = false;
            this.dgvNichos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNichos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNichos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNichos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNichos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumeroNicho,
            this.ColumnTamanoNicho,
            this.ColumnGaleria,
            this.ColumnEstadoNichos});
            this.dgvNichos.Location = new System.Drawing.Point(0, 19);
            this.dgvNichos.Name = "dgvNichos";
            this.dgvNichos.ReadOnly = true;
            this.dgvNichos.Size = new System.Drawing.Size(454, 190);
            this.dgvNichos.TabIndex = 0;
            this.dgvNichos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNichos_CellDoubleClick);
            this.dgvNichos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNichos_KeyDown);
            // 
            // ColumnNumeroNicho
            // 
            this.ColumnNumeroNicho.DataPropertyName = "NumeroNicho";
            this.ColumnNumeroNicho.HeaderText = "NumeroNicho";
            this.ColumnNumeroNicho.Name = "ColumnNumeroNicho";
            this.ColumnNumeroNicho.ReadOnly = true;
            // 
            // ColumnTamanoNicho
            // 
            this.ColumnTamanoNicho.DataPropertyName = "TamanoNicho";
            this.ColumnTamanoNicho.HeaderText = "TamanoNicho";
            this.ColumnTamanoNicho.Name = "ColumnTamanoNicho";
            this.ColumnTamanoNicho.ReadOnly = true;
            // 
            // ColumnGaleria
            // 
            this.ColumnGaleria.DataPropertyName = "Galeria";
            this.ColumnGaleria.HeaderText = "Galeria";
            this.ColumnGaleria.Name = "ColumnGaleria";
            this.ColumnGaleria.ReadOnly = true;
            // 
            // ColumnEstadoNichos
            // 
            this.ColumnEstadoNichos.DataPropertyName = "EstadoNichos";
            this.ColumnEstadoNichos.HeaderText = "EstadoNichos";
            this.ColumnEstadoNichos.Name = "ColumnEstadoNichos";
            this.ColumnEstadoNichos.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvNichos);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Lista ]";
            // 
            // _00014_Nichos_Registrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "_00014_Nichos_Registrados";
            this.Text = "Nichos Registrados";
            this.Load += new System.EventHandler(this._00014_Nichos_Registrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNichos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvNichos;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroNicho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTamanoNicho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGaleria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoNichos;
    }
}