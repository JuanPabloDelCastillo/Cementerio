using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement.Vista
{
    public partial class Reporterint : Form
    {
        public List<TrasladoInt> inte = new List<TrasladoInt>();
        public Reporterint()
        {
            InitializeComponent();
        }

        private void Reporterint_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cementerioDataSet1.TrasladoInt' Puede moverla o quitarla según sea necesario.
            this.trasladoIntTableAdapter.Fill(this.cementerioDataSet1.TrasladoInt);
            // TODO: esta línea de código carga datos en la tabla 'cementerioDataSet1.TrasladoInt' Puede moverla o quitarla según sea necesario.
            //this.trasladoIntTableAdapter.Fill(this.cementerioDataSet1.TrasladoInt);
            ////this.trasladoExtTableAdapter.Fill(this.dataSet2.TrasladoInt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", inte));
            this.reportViewer1.RefreshReport();
            //reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);este codigo es pa que puedas tener una vista completa de la hoja
            //this.reportViewer1.RefreshReport();
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            this.Show();
            this.reportViewer1.RefreshReport();
        }
    }
}
