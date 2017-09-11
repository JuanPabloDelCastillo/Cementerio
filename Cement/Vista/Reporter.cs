using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Microsoft.Reporting.WinForms;

namespace Cement.Vista
{
    public partial class Reporter : Form
    {
        public List<TrasladoExt> ext = new List<TrasladoExt>();
        public Reporter()
        {
            InitializeComponent();
        }

        private void Reporter_Load(object sender, EventArgs e)
        {
            this.trasladoExtTableAdapter.Fill(this.dataSet1.TrasladoExt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ext));
            this.reportViewer1.RefreshReport();
            //reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);este codigo es pa que puedas tener una vista completa de la hoja
            //this.reportViewer1.RefreshReport();
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            this.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

