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
    public partial class _000022_TrasladoExtJardin : Form
    {
        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();
        public _000022_TrasladoExtJardin()
        {
            InitializeComponent();
            txtBusqueda.Clear();
            cargarCodigoCem();
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
        }

        private void _000022_TrasladoExtJardin_Load(object sender, EventArgs e)
        {

            this.dgvCausante.DataSource = this.objCausante.MostrarTodos();

            txtBusqueda.Clear();
            btnTrasladar.Enabled = false;
            btnEditar.Enabled = true;
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

        public void cargarCodigoCem()
        {
            try
            {
                //Nomenc objNomencN = new Nomenc();
                //objNomencN.CodNomenc = 1;
                this.cmbCodCem.ValueMember = "id_Nomenc";
                this.cmbCodCem.DisplayMember = "Codcem";
                this.cmbCodCem.DataSource = new Nomenc().MostrarReporte();//usando la clase nomenc
                //cmbCodCem.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00012_Traslado_ExternoJardin objForm = new _00012_Traslado_ExternoJardin(this.objCausante);//enviar como parametro un nuevo causante al constructor de la clase.
                objForm.Text = "FORMULARIO DE TRASLADO EXTERNO";
                objForm.btnLimpiar.Enabled = false;
                objForm.btnGuardar.Visible = true;
                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                //objForm.cmbTramite.Enabled = true;
                objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;
                //objForm.txtNicho_Numero.Enabled = false;
                //objForm.txtTamNicho.Enabled = false;
                //objForm.txtGaleria.Enabled = false;
                //objForm.txtEstado.Enabled = false;                              
                objForm.txtLote.Enabled = false;
                objForm.txtFolio.Enabled = false;
                objForm.txtNombreCuerpo.Enabled = false;
                objForm.txtDni.Enabled = false;
                objForm.txtEdad.Enabled = false;
                //objForm.txtMeses.Enabled = false;
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
                objForm.imgFoto.Enabled = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
                btnTrasladar.Enabled = false;
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        private void ActivarDesactivarControles()
        {
            if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Nicho")
            {

                txtNicho_Numero.Enabled = true;
                txtTamNicho.Enabled = true;
                txtGaleria.Enabled = true;
                //txtEstado.Enabled = true;
                txtSeccion.Enabled = false;
                txtZona.Enabled = false;
                txtCuadro.Enabled = false;
                txtLote.Enabled = false;
            }
            else
            {
                txtNicho_Numero.Enabled = false;
                txtTamNicho.Enabled = false;
                txtGaleria.Enabled = false;
                //txtEstado.Enabled = false;
                txtZona.Enabled = true;
                txtCuadro.Enabled = true;
                txtLote.Enabled = true;
            }


            if (cmbCodCem.Text == "JARDIN" && cmbTipoConst.Text == "Sepultura")
            {
                txtSeccion.Enabled = true;
                txtGaleria.Enabled = false;
                txtTamNicho.Enabled = false;
                txtNicho_Numero.Enabled = false;
                txtZona.Enabled = false;
                txtCuadro.Enabled = true;
                txtLote.Enabled = true;
            }
            else
            {
                txtSeccion.Enabled = false;

            }
            //    LimpiarCampos();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dgvCausante.DataSource;
            objBindingSource.Filter = "Nombre LIKE '%" + this.txtBusqueda.Text + "%'";
            this.dgvCausante.DataSource = objBindingSource.DataSource;
        }

        private void cmbCodCem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
                ActivarDesactivarControles();
            }
            catch (Exception ex)
            {

            }

            Nomenc objNomencJ = new Nomenc();

            if (cmbCodCem.SelectedIndex != 2)
            {
                this.btnTrasladar.Enabled = false;
            }

            else
            {
                this.btnTrasladar.Enabled = true;
            }
        }

        private void txtSeccion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "Seccion = '" + this.txtSeccion.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
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
            ActivarDesactivarControles();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
               _00012_Traslado_ExternoJardin objForm = new _00012_Traslado_ExternoJardin(this.objCausante);//enviar como parametro un nuevo causante

                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                //objForm.cmbTramite.Enabled = false;
                objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;
                //objForm.txtTamNicho.Enabled = false;
                //objForm.txtNicho_Numero.Enabled = false;
                objForm.txtLote.Enabled = false;
                objForm.txtFolio.Enabled = false;
                objForm.txtNombreCuerpo.Enabled = false;
                objForm.txtDni.Enabled = false;
                objForm.txtEdad.Enabled = false;
                //objForm.txtMeses.Enabled = false;
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
                objForm.imgFoto.Enabled = false;
                objForm.cmbFechaTrasl.Enabled = false;
                objForm.cmbTraslado.Enabled = false;

                objForm.btnEliminar.Enabled = true;
                objForm.btnLimpiar.Enabled = false;
                objForm.btnNuevoCem.Enabled = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
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

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }
    }
}
