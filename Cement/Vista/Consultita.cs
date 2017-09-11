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
    public partial class Consultita : Form
    {
        TrasladoInt objTraslado = new TrasladoInt();
        Causante objCausante = new Causante();
        public Consultita()
        {
            InitializeComponent();
            cargarCodigoCem();

            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
        }

        public void cargarCodigoCem()
        {
            try
            {
                //TrasladoInt objNomenc = new TrasladoInt();
                //objNomenc.id_Nomenc = 1;
                this.cmbCodCem.ValueMember = "id_Nomenc";
                this.cmbCodCem.DisplayMember = "Codcem";
                this.cmbCodCem.DataSource = new Nomenc().MostrarTodos();//usando la clase nomenc
                cmbCodCem.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarConst_Tipo(int id_Nomenc)
        {
            try
            {
                Construcc_Tipo objConstrucc_Tipo = new Construcc_Tipo();
                objConstrucc_Tipo.id_Nomenc = id_Nomenc;
                this.cmbTipoConst.ValueMember = "id_Construccion";
                this.cmbTipoConst.DisplayMember = "Nombre_C";
                this.cmbTipoConst.DataSource = objConstrucc_Tipo.MostrarTodos();
                cmbTipoConst.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlConnection conn = new SqlConnection("Data source=B-PC\\SQLEXP;DataBase=Cementerio;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            int iCodigocementerio = 0; int iTipocontruccion = 0;

            if (this.cmbCodCem.SelectedIndex != -1)
                iCodigocementerio = (int)this.cmbCodCem.SelectedValue;
            if (this.cmbTipoConst.SelectedIndex != -1)
                iTipocontruccion = (int)this.cmbTipoConst.SelectedValue;
            StringBuilder sComando = new StringBuilder();
            sComando.Append("Select * from TrasladoInt where ");
            //sComando.Append("Select I.Codcem, I.Seccion, I.Cuadro, I.Zona, I.Lote, I.N_Codcem, I.N_Seccion, I.N_Cuadro, I.N_Zona, I.N_Lote, S.Nombre_C from TrasladoInt AS I LEFT OUTER JOIN Construcc_Tipo AS S ON I.id_Construccion = S.id_Construccion where ");
            if (iCodigocementerio != 0)
                sComando.Append(" id_Nomenc = " + iCodigocementerio + " and ");
            if (iTipocontruccion != 0)
                sComando.Append(" id_Construccion = " + iTipocontruccion + " and ");
            sComando.Append(" Fecha_TrasladoInt between '" + dateTimePicker_Desde.Value.ToString() + "' and '" + dateTimePicker_Hasta.Value.ToString() + "'");
            SqlDataAdapter obj = new SqlDataAdapter(sComando.ToString(), conn);
            DataTable sd = new DataTable();
            obj.Fill(sd);
            dataGridView1.DataSource = sd;
        }

        //select ProductID, ProductName, C.CategoryID, CategoryName, C.Description, UnitPrice, UnitsInStock
        //       from dbo.Products P left outer join dbo.Categories C
        //        on P.CategoryID = C.CategoryID


        private void cmbCodCem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
                //ActivarDesactivarControles();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbTipoConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ActivarDesactivarControles();
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dataGridView1.DataSource;
            if (this.cmbCodCem.SelectedValue != null)
            {
                if (this.cmbTipoConst.SelectedValue != null)
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCem.SelectedValue.ToString() + "' AND id_Construccion = '" + this.cmbTipoConst.SelectedValue.ToString() + "'";
                }
                else
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCem.SelectedValue.ToString() + "'";
                }
            }
            this.dataGridView1.DataSource = objBindingSource.DataSource;
        }
    }
}
    
