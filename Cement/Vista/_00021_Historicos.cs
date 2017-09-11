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
    public partial class _00021_Historicos : Form
    {
        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();
        public _00021_Historicos()
        {
            InitializeComponent();
            txtBusqueda.Clear();
            cargarCodigoCem();
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
        }      

        private void _00021_Historicos_Load(object sender, EventArgs e)
        {
            this.dgvCausante.DataSource = this.objCausante.MostrarHistorico();

            txtBusqueda.Clear();
            //btnModificar.Enabled = false;
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dgvCausante.DataSource;
            objBindingSource.Filter = "Nombre LIKE '%" + this.txtBusqueda.Text + "%'";
            this.dgvCausante.DataSource = objBindingSource.DataSource;
        }
        public void cargarCodigoCem()
        {
            try
            {
                //Nomenc objNomencN = new Nomenc();
                //objNomencN.CodNomenc = 1;
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

        private void cmbCodCem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
            }
            catch (Exception exp)
            {
            }
        }

        private void txtCuadro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "Cuadro = '" + this.txtCuadro.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtZona_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "Zona = '" + this.txtZona.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "Lote = '" + this.txtLote.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbTipoConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dgvCausante.DataSource;
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
            this.dgvCausante.DataSource = objBindingSource.DataSource;
        }

        private void txtCuadro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.MostrarHistorico();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00022_HistoricosVista objForm = new _00022_HistoricosVista(this.objCausante);

                objForm.cmbCodCem.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                objForm.cmbTramite.Enabled = false;
                objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;
                objForm.txtTamNicho.Enabled = false;
                objForm.txtNicho_Numero.Enabled = false;
                objForm.txtLote.Enabled = false;
                objForm.txtFolio.Enabled = false;
                objForm.txtNombreCuerpo.Enabled = false;
                objForm.txtDni.Enabled = false;
                objForm.txtEdad.Enabled = false;
                objForm.txtMeses.Enabled = false;
                objForm.SexoF.Enabled = false;
                objForm.SexoM.Enabled = false;
                objForm.txtNacionalidad.Enabled = false;
                objForm.cmbFechaFallec.Enabled = false;
                objForm.cmbFechaInhuma.Enabled = false;
                objForm.txtResponsable.Enabled = false;
                objForm.txtEmpNumAfil.Enabled = false;
                objForm.cmbEmpresa.Enabled = false;
                objForm.btnEmpresa.Enabled = false;
                objForm.txtObservaciones.Enabled = false;
                objForm.imgFoto.Enabled = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarHistorico();
            }
            else { MessageBox.Show("Atención!!!", "El registro con el siguiente Dni:  " + this.objCausante.Dni +   "        fue dado de baja.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
