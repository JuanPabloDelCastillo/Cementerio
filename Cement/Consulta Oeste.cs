using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cement
{
    public partial class Consulta_Oeste : Form
    {
        public Consulta_Oeste()
        {
            InitializeComponent();
            txtBusqueda.Clear();
            cargarCodigoCem();
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
        }
        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();

        private void Consulta_Oeste_Load(object sender, EventArgs e)
        {
            this.dgvCausante.DataSource = this.objCausante.MostrarCausantesOeste();

            txtBusqueda.Clear();
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

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
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
                Nomenc objNomencN = new Nomenc();
                objNomencN.CodNomenc = 1;
                this.cmbCodCem.ValueMember = "id_Nomenc";
                this.cmbCodCem.DisplayMember = "Codcem";
                this.cmbCodCem.DataSource = objNomencN.MostrarTodos();//usando la clase nomenc
                //cmbCodCem.SelectedIndex = -1;

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

            //valida el comboCem de la Grid

            Nomenc objNomencO = new Nomenc();

            //if (cmbCodCem.SelectedText != "OESTE" & cmbCodCem.SelectedText != "JARDIN")
            //{
            //    this.btnModificar.Enabled = true;


            if (cmbCodCem.SelectedIndex != 0)
            {
                ////    if (this.dgvCausante.Rows.Count == 0)
                ////    {
                ////        return;
                ////    }
                ////    int pos = dgvCausante.CurrentRow.Index;
                ////    try
                ////    {
                ////        bool Estado = Convert.ToBoolean(dgvCausante.Rows[pos].Cells["ColumnEstado"].Value);
                ////        if (Estado)


                //btnModificar.Enabled = false;

            }
            else
            {
                ////btnModificar.Enabled = true;
            }

        }

        private void txtCuadro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "Codcem = '" + this.cmbCodCem.Text + "' AND Cuadro LIKE '%" + this.txtCuadro.Text + "%' AND Zona LIKE '%" + this.txtZona.Text + "%' AND Lote LIKE '%" + this.txtLote.Text + "%'";
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
                objBindingSource.Filter = "Codcem = '" + this.cmbCodCem.Text + "' AND Cuadro LIKE '%" + this.txtCuadro.Text + "%' AND Zona LIKE '%" + this.txtZona.Text + "%' AND Lote LIKE '%" + this.txtLote.Text + "%'";
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
                objBindingSource.Filter = "Codcem = '" + this.cmbCodCem.Text + "' AND Cuadro LIKE '%" + this.txtCuadro.Text + "%' AND Zona LIKE '%" + this.txtZona.Text + "%' AND Lote LIKE '%" + this.txtLote.Text + "%'";
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                FormConsultarOeste objForm = new FormConsultarOeste(this.objCausante);//enviar como parametro un nuevo causante 

                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                //objForm.cmbTramite.Enabled = false;
                objForm.txtSeccion.Enabled = false;
                objForm.txtNCuadro.Enabled = false;
                objForm.txtNZona.Enabled = false;
                //objForm.txtTamNicho.Enabled = false;
                //objForm.txtNicho_Numero.Enabled = false;
                objForm.txtNLote.Enabled = false;
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
                //objForm.txtResponsable.Enabled = false;
                //objForm.txtEmpNumAfil.Enabled = false;
                objForm.cmbEmpresa.Enabled = false;
                objForm.btnEmpresa.Enabled = false;
                objForm.txtObservaciones.Enabled = false;
                //objForm.imgFoto.Enabled = false;
                //objForm.cmbCemInt.Enabled = false;
                //objForm.cmbTipoConstInt.Enabled = false;
                //objForm.txtNSeccion.Enabled = false;
                objForm.txtNCuadro.Enabled = false;
                objForm.txtNZona.Enabled = false;
                objForm.txtNLote.Enabled = false;

                objForm.txtNNumNicho.Enabled = false;
                objForm.txtNTamNicho.Enabled = false;
                objForm.txtNGaleria.Enabled = false;

                if (this.objCausante.Construcc_Tipo.Nombre_C != "Nicho")
                {
                    objForm.label8.Visible = false;
                    objForm.txtNNumNicho.Visible = false;
                    objForm.txtNTamNicho.Visible = false;
                    objForm.label29.Visible = false;
                    objForm.label28.Visible = false;
                    objForm.txtNGaleria.Visible = false;
                }
                



                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarCausantesOeste();
            }
            else
            {
                MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
