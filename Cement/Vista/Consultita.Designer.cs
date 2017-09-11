namespace Cement.Vista
{
    partial class Consultita
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
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodCem = new System.Windows.Forms.ComboBox();
            this.cmbTipoConst = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.AllowDrop = true;
            this.dateTimePicker_Desde.CustomFormat = "\'Fecha: \' dd/MM/yyyy \'Hora: \' HH:mm tt";
            this.dateTimePicker_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(202, 94);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Desde.TabIndex = 0;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.AllowDrop = true;
            this.dateTimePicker_Hasta.CustomFormat = "\'Fecha: \' dd/MM/yyyy \'Hora: \' HH:mm tt";
            this.dateTimePicker_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(534, 93);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker_Hasta.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(682, 213);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Construcc.Tipo";
            // 
            // cmbCodCem
            // 
            this.cmbCodCem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodCem.FormattingEnabled = true;
            this.cmbCodCem.Location = new System.Drawing.Point(268, 32);
            this.cmbCodCem.Name = "cmbCodCem";
            this.cmbCodCem.Size = new System.Drawing.Size(70, 21);
            this.cmbCodCem.TabIndex = 42;
            this.cmbCodCem.SelectedIndexChanged += new System.EventHandler(this.cmbCodCem_SelectedIndexChanged);
            // 
            // cmbTipoConst
            // 
            this.cmbTipoConst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConst.FormattingEnabled = true;
            this.cmbTipoConst.Location = new System.Drawing.Point(531, 32);
            this.cmbTipoConst.Name = "cmbTipoConst";
            this.cmbTipoConst.Size = new System.Drawing.Size(92, 21);
            this.cmbTipoConst.TabIndex = 43;
            this.cmbTipoConst.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConst_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cement";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(788, 58);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(117, 55);
            this.btnReporte.TabIndex = 45;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 418);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCodCem);
            this.Controls.Add(this.cmbTipoConst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.dateTimePicker_Desde);
            this.Name = "Consultita";
            this.Text = "Consultita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbCodCem;
        public System.Windows.Forms.ComboBox cmbTipoConst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReporte;
    }
}