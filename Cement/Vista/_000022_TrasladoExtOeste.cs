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
    public partial class _000022_TrasladoExtOeste : Form
    {
        private Causante objCausante = new Causante();
        public TrasladoExt objTrasladoExt = new TrasladoExt();
        private NomencCausante objNomencCausante = new NomencCausante();
        public _000022_TrasladoExtOeste()
        {
            InitializeComponent();
            btnTrasladar.Enabled = false;
            txtBusqueda.Clear();
            cargarCodigoCem();
            cmbCodCem.SelectedIndex = -1;
            this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
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
                Nomenc objNomencN = new Nomenc();
                objNomencN.CodNomenc = 1;
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

        private void Limpiar()
        {
            //this.txtSeccion.Clear();
            this.txtCuadro.Clear();
            this.txtZona.Clear();
            this.txtLote.Clear();
            this.txtTamNicho.Clear();
            this.txtNicho_Numero.Clear();
            this.txtGaleria.Clear();

        }

        private void LimpiarCampos()
        {
            if (this.cmbCodCem.Text == "OESTE")
            {
                txtCuadro.Text = null;
                //Limpiar();
            }
            if (this.cmbCodCem.Text == "NORTE")
            {
                Limpiar();
            }
            else if (this.cmbCodCem.Text == "JARDIN")
            {
                Limpiar();
            }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar                
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00012_Traslado_ExternoOeste objForm = new _00012_Traslado_ExternoOeste(this.objCausante);//enviar como parametro un nuevo causante al constructor de la clase.
                objForm.Text = "TRASLADO EXTERNO OESTE";
                objForm.btnLimpiar.Enabled = false;
                objForm.btnTrasladar.Visible = true;
                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                objForm.cmbTramite.Enabled = true;
                //objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;
                //objForm.txtNicho_Numero.Enabled = false;
                //objForm.txtTamNicho.Enabled = false;
                //objForm.txtGaleria.Enabled = false;
                //objForm.txtEstado.Enabled = false;                              
                objForm.txtLote.Enabled = false;
                //objForm.txtFolio.Enabled = false;
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

                ////dgvCausante.CurrentRow.Cells["ColumnDni"].ReadOnly = true;                
            }

            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }


        private void ActivarDesactivarControles()
        {
            if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Nicho")
            {
                //Limpiar();
                txtNicho_Numero.Enabled = true;
                txtTamNicho.Enabled = true;
                txtGaleria.Enabled = true;
                //txtEstado.Enabled = true;
                txtSeccion.Clear();
                txtSeccion.Enabled = false;
                txtZona.Clear();
                txtZona.Enabled = false;
                txtCuadro.Clear();
                txtCuadro.Enabled = false;
                txtLote.Clear();
                txtLote.Enabled = false;
            }

            if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Sepultura" || cmbTipoConst.Text == "Sotanito" || cmbTipoConst.Text == "Capilla" || cmbTipoConst.Text == "Mausoleo" || cmbTipoConst.Text == "Panteon")
            {
                //Limpiar();
                txtGaleria.Clear();
                txtGaleria.Enabled = false;
                txtTamNicho.Clear();
                txtTamNicho.Enabled = false;
                txtNicho_Numero.Clear();
                txtNicho_Numero.Enabled = false;
                txtSeccion.Enabled = false;
                txtCuadro.Clear();
                txtCuadro.Enabled = true;
                txtZona.Clear();
                txtZona.Enabled = true;
                txtLote.Clear();
                txtLote.Enabled = true;
            }

            if (cmbCodCem.Text == "OESTE")
            {
                //Limpiar();
                //txtSeccion.Enabled = false;
                txtGaleria.Enabled = false;
                txtTamNicho.Enabled = false;
                txtNicho_Numero.Enabled = false;
                txtCuadro.Clear();
                txtCuadro.Enabled = true;
                txtZona.Clear();
                txtZona.Enabled = true;
                txtLote.Clear();
                txtLote.Enabled = true;
            }


            if (cmbCodCem.Text == "JARDIN" && cmbTipoConst.Text == "Sepultura")
            {
                //Limpiar();
                txtSeccion.Clear();
                txtSeccion.Enabled = true;
                txtCuadro.Clear();
                txtCuadro.Enabled = true;
                txtZona.Clear();
                txtZona.Enabled = true;
                txtLote.Clear();
                txtLote.Enabled = true;
                txtGaleria.Clear();
                txtGaleria.Enabled = false;
                txtTamNicho.Clear();
                txtTamNicho.Enabled = false;
                txtNicho_Numero.Clear();
                txtNicho_Numero.Enabled = false;
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
            this.btnTrasladar.Enabled = false;
            cmbCodCem.SelectedIndex = -1;
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

            Nomenc objNomencOeste = new Nomenc();

            if (cmbCodCem.SelectedIndex != 0)
            {
                this.btnTrasladar.Enabled = false;
            }
            else
            {
                this.btnTrasladar.Enabled = true;

            }
          }
                   
    
        private void _000022_TrasladoExtOeste_Load(object sender, EventArgs e)
        {
            this.dgvCausante.DataSource = this.objCausante.MostrarCausantesSinTrasladosExt();
            //cmbCodCem.SelectedIndex = -1;
            txtBusqueda.Clear();
            btnTrasladar.Enabled = false;
            btnEditar.Enabled = true;
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

        private void txtLote_TextChanged_1(object sender, EventArgs e)
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

        private void txtNicho_Numero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "NumeroNicho = '" + this.txtNicho_Numero.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtTamNicho_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "TamanoNichoT = '" + this.txtTamNicho.Text + "'";
                this.dgvCausante.DataSource = objBindingSource.DataSource;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtGaleria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvCausante.DataSource;
                objBindingSource.Filter = "GaleriaN = '" + this.txtGaleria.Text + "'";
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

        private void txtZona_KeyPress_1(object sender, KeyPressEventArgs e)
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


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00001_Inhuma objForm = new _00001_Inhuma(this.objCausante);//enviar como parametro un nuevo causante 

                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                objForm.cmbTramite.Enabled = false;
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
                objForm.txtResponsable.Enabled = false;
                objForm.txtEmpNumAfil.Enabled = false;
                objForm.cmbEmpresa.Enabled = false;
                objForm.btnEmpresa.Enabled = false;
                objForm.txtObservaciones.Enabled = false;
                objForm.imgFoto.Enabled = false;

                objForm.btnEliminar.Enabled = true;
                objForm.btnLimpiar.Enabled = false;

                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
            }
            else
            {
                MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo causante ya que vamos a modificar.
            this.objCausante.Dni = this.dgvCausante.CurrentRow.Cells["ColumnDni"].Value.ToString();//asignando el DNI que voy a buscar
            this.objCausante.Seleccionar();//buscando por DNI(clave primaria)
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))
            {
                _00012_Traslado_ExternoOeste objForm = new _00012_Traslado_ExternoOeste(this.objCausante);//enviar como parametro un nuevo causante 
  
                objForm.cmbCodCem.Enabled = false;
                objForm.btnNuevoCement.Enabled = false;
                objForm.cmbTipoConst.Enabled = false;
                objForm.cmbTramite.Enabled = false;
                //objForm.txtSeccion.Enabled = false;
                objForm.txtCuadro.Enabled = false;
                objForm.txtZona.Enabled = false;

                objForm.txtTamNicho.Visible = true;
                objForm.txtNicho_Numero.Visible = true;
                objForm.txtGaleria.Visible = true;
                objForm.txtTamNicho.Enabled = false;
                objForm.txtNicho_Numero.Enabled = false;
                objForm.txtGaleria.Enabled = false;

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
                MessageBox.Show("Atención!!!", "El registro con el siguiente DNI: " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNicho_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtTamNicho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void txtGaleria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void dgvCausante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (cmbCodCem.SelectedIndex != -1)//verificamos que se seleccione algo en el combo
                {
                    int pos = dgvCausante.CurrentRow.Index;//extraemos la posicion de la fila seleccionada en el grid                    
                    try
                    {
                        bool Estado = Convert.ToBoolean(dgvCausante.Rows[pos].Cells["ColumnEstado"].Value);//extraemos en valos true o false
                        if (Estado)//verificamos, si es true activamos en boton
                        {
                            btnTrasladar.Enabled = true;

                        }
                        else//sino desactivamos en boton
                        {
                            btnTrasladar.Enabled = false;
                            MessageBox.Show("Atención!!!", "El registro con el siguiente DNI : " + this.objCausante.Dni, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }     
    }
}
    

