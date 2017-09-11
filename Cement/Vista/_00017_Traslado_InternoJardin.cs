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
    public partial class _00017_Traslado_InternoJardin : Form
    {
        public _00017_Traslado_InternoJardin()
        {
            InitializeComponent();
            txtBusqueda.Clear();
            cargarCodCemInt();
            this.cmbTipoConstInt.SelectedValue = this.objCausante.id_Construccion;
        }
        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();
        private TrasladoInt objTrasladoInt = new TrasladoInt();

        private void _00017_Traslado_InternoJardin_Load(object sender, EventArgs e)
        {
            this.dgvInterno.DataSource = this.objCausante.MostrarTodos();
            btnTrasladar.Enabled = false;
        }
        public void cargarCodCemInt()
        {
            try
            {
                Nomenc objNomencJardin = new Nomenc();
                objNomencJardin.CodNomenc = 3;
                this.cmbCodCemInt.ValueMember = "id_Nomenc";
                this.cmbCodCemInt.DisplayMember = "Codcem";
                this.cmbCodCemInt.DataSource = objNomencJardin.MostrarTodos();//usando la clase nomenc
                cmbCodCemInt.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarConstInt(int id_Nomenc)
        {
            try
            {
                Construcc_Tipo objConstrucc_Tipo = new Construcc_Tipo();
                objConstrucc_Tipo.id_Nomenc = id_Nomenc;
                this.cmbTipoConstInt.ValueMember = "id_Construccion";
                this.cmbTipoConstInt.DisplayMember = "Nombre_C";
                this.cmbTipoConstInt.DataSource = objConstrucc_Tipo.MostrarTodos();
                cmbTipoConstInt.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            this.objCausante.Dni = this.dgvInterno.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00018_Traslado_Interno_Jardin objForm = new _00018_Traslado_Interno_Jardin(this.objCausante);//enviar como parametro un nuevo causante al constructor de la clase.
                objForm.Text = "TRASLADO INTERNO JARDIN";
                //objForm.btnLimpiar.Enabled = false;
                objForm.btnGuardar.Enabled = true;
                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                objForm.cmbTramiteInt.Enabled = true;
                objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;
                objForm.txtNicho_Numero.Enabled = false;
                objForm.txtTamNicho.Enabled = false;
                objForm.txtGaleria.Enabled = false;
                objForm.txtEstado.Enabled = false;
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
                //           objForm.imgFoto.Enabled = false;

                objForm.btnGuardar.Visible = true;
                objForm.btnGuardar.Enabled = false;
                objForm.btnLimpiar.Visible = false;
                objForm.btnLimpiar.Enabled = false;
                objForm.btnEliminar.Visible = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvInterno.DataSource = this.objCausante.MostrarTodos();

                btnTrasladar.Enabled = false;
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void cmbCodCemInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarConstInt((int)this.cmbCodCemInt.SelectedValue);
            }
            catch (Exception ex)
            {

            }

            //**Valida el comboCem de la Grid

            Nomenc objNomencJ = new Nomenc();

            if (cmbCodCemInt.SelectedText != "JARDIN")
            {
                this.btnTrasladar.Enabled = true;
            }
            else
            {
                this.btnTrasladar.Enabled = false;
            }
        }
            //*************
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dgvInterno.DataSource;
            objBindingSource.Filter = "Nombre LIKE '%" + this.txtBusqueda.Text + "%'";
            this.dgvInterno.DataSource = objBindingSource.DataSource;
        }

        private void txtCuadroInt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvInterno.DataSource;
                objBindingSource.Filter = "Cuadro = '" + this.txtCuadroInt.Text + "'";
                this.dgvInterno.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtZonaInt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvInterno.DataSource;
                objBindingSource.Filter = "Zona = '" + this.txtZonaInt.Text + "'";
                this.dgvInterno.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtLoteInt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvInterno.DataSource;
                objBindingSource.Filter = "Lote = '" + this.txtLoteInt.Text + "'";
                this.dgvInterno.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbTipoConstInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = this.dgvInterno.DataSource;
            if (this.cmbCodCemInt.SelectedValue != null)
            {
                if (this.cmbTipoConstInt.SelectedValue != null)
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCemInt.SelectedValue.ToString() + "' AND id_Construccion = '" + this.cmbTipoConstInt.SelectedValue.ToString() + "'";
                }
                else
                {
                    objBindingSource.Filter = "id_Nomenc = '" + this.cmbCodCemInt.SelectedValue.ToString() + "'";
                }
            }
            this.dgvInterno.DataSource = objBindingSource.DataSource;
        }

        private void txtCuadroInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtZonaInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtLoteInt_KeyPress(object sender, KeyPressEventArgs e)
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
            this.objCausante.Dni = this.dgvInterno.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00018_Traslado_Interno_Jardin objForm = new _00018_Traslado_Interno_Jardin(this.objCausante);//enviar como parametro un nuevo causante 

                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                //objForm.cmbTramite.Enabled = false;
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
                //objForm.txtResponsable.Enabled = false;
                //objForm.txtEmpNumAfil.Enabled = false;
                objForm.cmbEmpresa.Enabled = false;
                objForm.btnEmpresa.Enabled = false;
                objForm.txtObservaciones.Enabled = false;
                //objForm.imgFoto.Enabled = false;
                objForm.cmbCemInt.Enabled = false;
                objForm.cmbTipoConstInt.Enabled = false;
                objForm.txtNSeccion.Enabled = false;
                objForm.txtNCuadro.Enabled = false;
                objForm.txtNZona.Enabled = false;
                objForm.txtNLote.Enabled = false;
                objForm.txtNNumNicho.Enabled = false;
                objForm.txtNTamNicho.Enabled = false;
                objForm.txtNGaleria.Enabled = false;
                objForm.txtNEstado.Enabled = false;
                objForm.cmbFechaTrasladoInt.Enabled = false;

                objForm.btnEliminar.Visible = false;
                objForm.btnLimpiar.Enabled = false;
                objForm.btnGuardar.Visible = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvInterno.DataSource = this.objCausante.MostrarTodos();
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

