using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement.Vista
{
    public partial class _00019_Consultas_Traslados_Externos : Form
    {
        TrasladoExt objTraslado = new TrasladoExt();
        Causante objCausante = new Causante();
        public _00019_Consultas_Traslados_Externos()
        {
            InitializeComponent();
            cargarCodigoCem();
            this.cmbTipoConstExt.SelectedValue = this.objCausante.id_Construccion;
        }

        public void cargarCodigoCem()
        {
            try
            {
                //Nomenc objNomencN = new Nomenc();
                //objNomencN.CodNomenc = 2;
                this.cmbCodCem.ValueMember = "id_Nomenc";
                this.cmbCodCem.DisplayMember = "Codcem";
                this.cmbCodCem.DataSource = new Nomenc().MostrarReporte();//usando la clase nomenc
                cmbCodCem.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarConst(int id_Nomenc) 
        {
            try
            {
                Construcc_Tipo objConstrucc = new Construcc_Tipo();
                objConstrucc.id_Nomenc = id_Nomenc;
                this.cmbTipoConstExt.ValueMember = "id_Construccion";
                this.cmbTipoConstExt.DisplayMember = "Nombre_C";
                this.cmbTipoConstExt.DataSource = objConstrucc.MostrarTodos();
                cmbTipoConstExt.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-9SE709L\SQLEXPRESS; Initial Catalog = Cementerio; Integrated Security = True");
        SqlConnection conn = new SqlConnection(@"Data source=JUANPABLO-PC\SQLEXPRESS;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300");


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int iCodigocementerio = 0; int iTipocontruccion = 0;

            if (this.cmbCodCem.SelectedIndex != -1)
                iCodigocementerio = (int)this.cmbCodCem.SelectedValue;
            if (this.cmbTipoConstExt.SelectedIndex != -1)
                iTipocontruccion = (int)this.cmbTipoConstExt.SelectedValue;
            StringBuilder sComando = new StringBuilder();
            sComando.Append("Select  id_Nomenc, id_Construccion, Dni, Nombre, Codcem, Nombre_C, Seccion, Cuadro, Zona, Lote, Nombre_Emp, TamNicho, Nicho_Numero, Galeria, Fecha_Traslado, OtroCem, Observaciones from TrasladoExt where ");
            if (iCodigocementerio != 0)
                sComando.Append(" id_Nomenc = " + iCodigocementerio + " and ");
            if (iTipocontruccion != 0)
                sComando.Append(" id_Construccion = " + iTipocontruccion + " and ");
            sComando.Append(" Fecha_Traslado between '" + dateTimePicker_Desde.Value.ToString() + "' and '" + dateTimePicker_Hasta.Value.ToString() + "'");
            SqlDataAdapter obj = new SqlDataAdapter(sComando.ToString(), conn);
            DataTable sd = new DataTable();
            obj.Fill(sd);
            dataGridView1.DataSource = sd;
            txtCantidad.Text = Convert.ToString(dataGridView1.RowCount);

        }

        private void cmbCodCem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarConst((int)this.cmbCodCem.SelectedValue);
                //ActivarDesactivarControles();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbTipoConstExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dataGridView1.DataSource;
            if (this.cmbCodCem.SelectedValue != null)
            {
                if (this.cmbTipoConstExt.SelectedValue != null)
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCem.SelectedValue.ToString() + "' AND id_Construccion = '" + this.cmbTipoConstExt.SelectedValue.ToString() + "'";
                }
                else
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCem.SelectedValue.ToString() + "'";
                }
            }
            this.dataGridView1.DataSource = objBindingSource.DataSource;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnReport_Click(object sender, EventArgs e)
        //{           
        //    Reporter frm2 = new Reporter();
        //    foreach (DataGridViewRow dtg in dataGridView1.Rows)
        //    {
        //        TrasladoExt ext = new TrasladoExt();
        //        ext.Dni = dtg.Cells["ColumnDni"].Value.ToString();
        //        ext.Nombre_C = cmbTipoConstExt.SelectedText;
        //        ext.Fecha_Traslado = this.dateTimePicker_Desde.Value;
        //        ext.Fecha_Traslado = this.dateTimePicker_Hasta.Value;
        //        ext.Nombre = dtg.Cells["ColumnNombre"].Value.ToString();
        //        ext.Codcem = dtg.Cells["ColumnCodcem"].Value.ToString();
        //        ext.Cuadro = dtg.Cells["ColumnCuadro"].Value.ToString();
        //        ext.Zona = dtg.Cells["ColumnZona"].Value.ToString();
        //        ext.Lote = dtg.Cells["ColumnLote"].Value.ToString();
        //        ext.Nombre_C = dtg.Cells["ColumnNombre_C"].Value.ToString();
        //        ext.OtroCem = dtg.Cells["ColumnOtroCem"].Value.ToString();
        //        ext.Nombre_Emp = dtg.Cells["ColumnNombre_Emp"].Value.ToString();

        //        frm2.ext.Add(ext);
        //    }           
        //    frm2.Show();   
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporter frm2 = new Reporter();
            foreach (DataGridViewRow dtg in dataGridView1.Rows)
            {
                TrasladoExt ext = new TrasladoExt();
                ext.Dni = dtg.Cells["ColumnDni"].Value.ToString();
                ext.Nombre_C = cmbTipoConstExt.SelectedText;
                ext.Fecha_Traslado = this.dateTimePicker_Desde.Value;
                ext.Fecha_Traslado = this.dateTimePicker_Hasta.Value;
                ext.Nombre = dtg.Cells["ColumnNombre"].Value.ToString();
                ext.Codcem = dtg.Cells["ColumnCodcem"].Value.ToString();
                ext.Cuadro = dtg.Cells["ColumnCuadro"].Value.ToString();
                ext.Zona = dtg.Cells["ColumnZona"].Value.ToString();
                ext.Lote = dtg.Cells["ColumnLote"].Value.ToString();
                ext.Nombre_C = dtg.Cells["ColumnNombre_C"].Value.ToString();
                ext.OtroCem = dtg.Cells["ColumnOtroCem"].Value.ToString();
                ext.Nombre_Emp = dtg.Cells["ColumnNombre_Emp"].Value.ToString();

                frm2.ext.Add(ext);
            }
            frm2.Show();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

