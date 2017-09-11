namespace Cement.Vista
{
    partial class Reporter
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.trasladoExtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Cement.DataSet1();
            this.trasladoExtTableAdapter = new Cement.DataSet1TableAdapters.TrasladoExtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trasladoExtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.trasladoExtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cement.Vista.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1182, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // trasladoExtBindingSource
            // 
            this.trasladoExtBindingSource.DataMember = "TrasladoExt";
            this.trasladoExtBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trasladoExtTableAdapter
            // 
            this.trasladoExtTableAdapter.ClearBeforeFill = true;
            // 
            // Reporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 563);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporter";
            this.Text = "Reporter";
            this.Load += new System.EventHandler(this.Reporter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trasladoExtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource trasladoExtBindingSource;
        private DataSet1TableAdapters.TrasladoExtTableAdapter trasladoExtTableAdapter;
    }
}