using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Cement.Properties;
using Cement.Vista;
using System.Text;
using System.Windows.Forms;
using Entidades;


namespace Cement.Vista
{
    public partial class _00002_CausanteNorte : Form
    {

        public _00002_CausanteNorte()
        {

            InitializeComponent();
            txtBusqueda.Clear();
            cargarCodigoCem();
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;

        }

        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();

        private void _00002_CausanteNorte_Load(object sender, EventArgs e)
        {
            this.dgvCausante.DataSource = this.objCausante.MostrarTodos();

            txtBusqueda.Clear();
            btnModificar.Enabled = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //para enviar un nuevo causante como parametro tenemos 2 opciones:
            //1- crear una variable de tipo causante y enviarlo de la siguiente manera: 
            //Causante objCausante = new Causante();
            //_00001_Inhuma objForm = new _00001_Inhuma(objCausante);
            //2- enviarlo del modo directo sin crear variable para no ocupar espacios de memoria.
            _00001_InhumaNorte objForm = new _00001_InhumaNorte(new Causante());//enviar como parametro un nuevo causante
            objForm.Text = "Nueva Inhumación";
            //objForm.btnNuevoCem.Visible = false;
            //objForm.cmbTraslado.Visible = false;
            //objForm.groupBox4.Visible = false;
            //objForm.label18.Visible = false;
            //objForm.cmbFechaTrasl.Visible = false;
            objForm.ShowDialog();
            this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00001_InhumaNorte objForm = new _00001_InhumaNorte(this.objCausante);//enviar como parametro un nuevo causante al constructor de la clase.
                objForm.Text = "Modifica Inhumación";
                objForm.btnLimpiar.Enabled = false;
                objForm.btnGuardar.Enabled = true;
                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
                btnModificar.Enabled = false;
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Nomenc objNomencN = new Nomenc();
                objNomencN.CodNomenc = 2;
                this.cmbCodCem.ValueMember = "id_Nomenc";
                this.cmbCodCem.DisplayMember = "Codcem";
                this.cmbCodCem.DataSource = objNomencN.MostrarTodos();//usando la clase nomenc
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

            //valida el comboCem de la Grid

            Nomenc objNomencN = new Nomenc();

            if (cmbCodCem.SelectedText != "JARDIN")
            {
                this.btnModificar.Enabled = true;
            }
            else
            {
                this.btnModificar.Enabled = false;
            }

        }

        private void txtCuadro_TextChanged_1(object sender, EventArgs e)
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
        private void txtZona_TextChanged_1(object sender, EventArgs e)
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

        private void txtLote_TextChanged_1(object sender, EventArgs e)
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

        private void txtCuadro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtZona_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtLote_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00001_InhumaNorte objForm = new _00001_InhumaNorte(this.objCausante);//enviar como parametro un nuevo causante 

                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
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
                //objForm.txtMeses.Enabled = false;
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

                objForm.btnEliminar.Enabled = false;
                objForm.btnLimpiar.Enabled = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
    }

