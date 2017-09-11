namespace Cement.Vista
{
    partial class Reporterint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.trasladoIntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cementerioDataSet1 = new Cement.CementerioDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.trasladoIntTableAdapter = new Cement.CementerioDataSet1TableAdapters.TrasladoIntTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trasladoIntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cementerioDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // trasladoIntBindingSource
            // 
            this.trasladoIntBindingSource.DataMember = "TrasladoInt";
            this.trasladoIntBindingSource.DataSource = this.cementerioDataSet1;
            // 
            // cementerioDataSet1
            // 
            this.cementerioDataSet1.DataSetName = "CementerioDataSet1";
            this.cementerioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 21;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.trasladoIntBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cement.Vista.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(880, 456);
            this.reportViewer1.TabIndex = 0;
            // 
            // trasladoIntTableAdapter
            // 
            this.trasladoIntTableAdapter.ClearBeforeFill = true;
            // 
            // Reporterint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporterint";
            this.Text = "Reporterint";
            this.Load += new System.EventHandler(this.Reporterint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trasladoIntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cementerioDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CementerioDataSet1 cementerioDataSet1;
        private System.Windows.Forms.BindingSource trasladoIntBindingSource;
        private CementerioDataSet1TableAdapters.TrasladoIntTableAdapter trasladoIntTableAdapter;
    }
}