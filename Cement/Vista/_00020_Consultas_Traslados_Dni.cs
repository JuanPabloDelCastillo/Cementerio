using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement.Vista
{
    public partial class _00020_Consultas_Traslados_Dni : Form
    {
        private Causante objCausante = new Causante();
        public _00020_Consultas_Traslados_Dni()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data source=JUANPABLO-PC\SQLEXPRESS;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300");
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            StringBuilder sComando = new StringBuilder();
            sComando.Append("Select * from TrasladoExt where Dni = '" + txtDni.Text + "' ");
            SqlDataAdapter obj = new SqlDataAdapter(sComando.ToString(), conn);
                DataTable sd = new DataTable();
                obj.Fill(sd);
                dgvConsultaExt.DataSource = sd;         
            }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

