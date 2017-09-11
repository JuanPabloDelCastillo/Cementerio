using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Cement.Vista;
using System.Windows.Forms;
using Entidades;

namespace Cement
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00008_Empleado_Add().ShowDialog();
        }


        private void consultasPorNomenclaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00019_Consultas_Traslados_Externos().ShowDialog();
        }

        private void consultasTrasladosInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00020_Consultas_Traslados_Interno().ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menues().ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("F");
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
            Login frm = new Login();
            frm.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del Sistema?", "Mensaje de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

        //private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new Consultita().ShowDialog();
        //}


        private void inhumacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new _00002_Causante().ShowDialog();
        }

        private void trasladoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _000022_TrasladoExtOeste().ShowDialog();
        }

        private void trasladoInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00017_Traslado_InternoOeste().ShowDialog();
        }

        private void inhumacionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new _00002_CausanteNorte().ShowDialog();
        }

        private void trasladoExternoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new _000022_TrasladoExNorte().ShowDialog();
        }

        private void trasladoInternoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new _00017_Traslado_InternoNorte().ShowDialog();
        }

        private void nichosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00016_Nicho_Add().ShowDialog();
        }

        private void inhumacionesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new _00002_CausanteJardin().ShowDialog();
        }

        private void trasladoExternoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new _000022_TrasladoExtJardin().ShowDialog();
        }

        private void trasladoInternoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new _00017_Traslado_InternoJardin().ShowDialog();
        }

        private void norteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultasAHistoricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00021_Historicos().ShowDialog();
        }

        private void consultasPorDniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _00020_Consultas_Traslados_Dni().ShowDialog();
        }

        private void consultasNorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consulta_Norte().ShowDialog();
        }

        private void consultaOesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consulta_Oeste().ShowDialog();
        }

        private void btnMenuInhumaciones_Click(object sender, EventArgs e)
        {
            new _00002_Causante().ShowDialog();
        }

        private void btnMenuTrasladoInterno_Click(object sender, EventArgs e)
        {
            new _00017_Traslado_InternoOeste().ShowDialog();
        }

        private void btnMenuTrasladoExterno_Click(object sender, EventArgs e)
        {
            new _000022_TrasladoExtOeste().ShowDialog();
        }

        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            new Consulta_Norte().ShowDialog();
        }

        //private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //new _00008_Empleado_Add().ShowDialog();
        //}
    }
    }

