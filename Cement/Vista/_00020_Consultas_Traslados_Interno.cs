using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement.Vista
{
    public partial class _00020_Consultas_Traslados_Interno : Form
    {
        TrasladoInt objTrasladoInt = new TrasladoInt();
        Causante objCausante = new Causante();
        public _00020_Consultas_Traslados_Interno()
        {
            InitializeComponent();
            cargarCodigoCem();
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
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

        SqlConnection conn = new SqlConnection(@"Data source=B-PC\SQLEXPRESS;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;DataBase=Cementerio;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300");
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int iCodigocementerio = 0; int iTipocontruccion = 0;

            if (this.cmbCodCem.SelectedIndex != -1)
                iCodigocementerio = (int)this.cmbCodCem.SelectedValue;
            if (this.cmbTipoConst.SelectedIndex != -1)
                iTipocontruccion = (int)this.cmbTipoConst.SelectedValue;
            StringBuilder sComando = new StringBuilder();
            sComando.Append("Select  id_Nomenc, id_Construccion, Dni, Nombre, Codcem, Nombre_C, Seccion, Cuadro, Zona, Lote, N_Codcem, N_Seccion, N_Cuadro, N_Zona, N_Lote, Nombre_Emp, TamNicho, Nicho_Numero, Galeria, Fecha_TrasladoInt, Observaciones from TrasladoInt where");
            if (iCodigocementerio != 0)
                sComando.Append(" id_Nomenc = " + iCodigocementerio + " and ");
            if (iTipocontruccion != 0)
                sComando.Append(" id_Construccion = " + iTipocontruccion + " and ");
            sComando.Append(" Fecha_TrasladoInt between '" + dateTimePicker_Desde.Value.ToString() + "' and '" + dateTimePicker_Hasta.Value.ToString() + "'");
            SqlDataAdapter obj = new SqlDataAdapter(sComando.ToString(), conn);
            DataTable sd = new DataTable();
            obj.Fill(sd);
            dgvConsultaInt.DataSource = sd;
            txtCantidad.Text = Convert.ToString(dgvConsultaInt.RowCount);
        }

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
            objBindingSource.DataSource = this.dgvConsultaInt.DataSource;
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
            this.dgvConsultaInt.DataSource = objBindingSource.DataSource;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporterint frm1 = new Reporterint();
            foreach (DataGridViewRow dtg in dgvConsultaInt.Rows)
            {
                TrasladoInt inte = new TrasladoInt();
                inte.Dni = dtg.Cells["ColumnDni"].Value.ToString();
                inte.Nombre_C = cmbCodCem.SelectedText;
                inte.Fecha_TrasladoInt = this.dateTimePicker_Desde.Value;
                inte.Fecha_TrasladoInt = this.dateTimePicker_Hasta.Value;
                inte.Nombre = dtg.Cells["ColumnNombre"].Value.ToString();
                inte.Codcem = dtg.Cells["ColumnCodcem"].Value.ToString();
                inte.Cuadro = dtg.Cells["ColumnCuadro"].Value.ToString();
                inte.Zona = dtg.Cells["ColumnZona"].Value.ToString();
                inte.Lote = dtg.Cells["ColumnLote"].Value.ToString();
                inte.Nombre_C = dtg.Cells["ColumnNombre_C"].Value.ToString();
                //inte.OtroCem = dtg.Cells["ColumnOtroCem"].Value.ToString();
                inte.Nombre_Emp = dtg.Cells["ColumnNombre_Emp"].Value.ToString();


                frm1.inte.Add(inte);//AQUI DA ERROR PORQUE TODAVIA NO ESTA CREADO EL FORM DEL REPORTE DONDE SE CREA EL OBJETO
            }
            frm1.Show();
        }

        private void _00020_Consultas_Traslados_Interno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

