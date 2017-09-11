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
    public partial class _00012_Traslado_ExternoJardin : Form
    {
        private Causante objCausante = new Causante();
        private Historico objHistorico = new Historico();
        private TrasladoExt objTraslado = new TrasladoExt();
        private NomencCausante objNomencCausante = new NomencCausante();
        private Nicho objNicho = new Nicho();
        public _00012_Traslado_ExternoJardin(Causante paramCausante)
        {
            InitializeComponent();
            this.objCausante = paramCausante;// asignando el parametro de clase causante con la variable de la misma clase.
            cargarCodigoCem();
            //cargarGaleria();
            //cargarTramite();
            cargarEmpresas();
            CargarOtroCem();
            
            if (!string.IsNullOrEmpty(this.objCausante.ToString()))//si existe el causante se procede a mostrar sus datos.
            {
                if (this.objCausante.Sexo == "F")
                {
                    SexoF.Checked = true;
                }
                else
                {
                    SexoM.Checked = true;
                }
                this.cmbCodCem.SelectedValue = this.objCausante.id_Nomenc;
                this.cmbEmpresa.SelectedValue = this.objCausante.id_Empresa;
                this.cmbTipoConst.SelectedValue = this.objCausante.id_Construccion;
                //this.cmbTramite.SelectedValue = this.objCausante.id_Tramite;
                if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
                {
                    this.txtCuadro.Text = this.objCausante.NomencCausante.Cuadro;
                    this.txtZona.Text = this.objCausante.NomencCausante.Zona;
                    this.txtLote.Text = this.objCausante.NomencCausante.Lote;
                    this.txtSeccion.Text = this.objCausante.NomencCausante.Seccion;
                }

                //if (this.objCausante.Nicho != null)
                //{
                //this.txtNicho_Numero.Text = this.objCausante.Nicho.NumeroNicho;
                //this.txtTamNicho.Text = this.objCausante.Nicho.TamanoNicho.TamanoNichoT;
                //this.txtGaleria.Text = this.objCausante.Nicho.Galeria.GaleriaN;
                //this.txtEstado.Text = this.objCausante.Nicho.EstadoNicho.EstadoNichos;
                //}


                this.txtFolio.Text = this.objCausante.Folio;
                this.txtNombreCuerpo.Text = this.objCausante.Nombre;
                this.txtDni.Text = this.objCausante.Dni;
                this.txtEdad.Text = this.objCausante.Edad;
                //this.txtMeses.Text = this.objCausante.Edad_Meses;
                this.txtNacionalidad.Text = this.objCausante.Nacionalidad;
                this.cmbFechaFallec.Value = this.objCausante.FechaHora_Fall;
                this.cmbFechaInhuma.Value = this.objCausante.Fecha_Inhum;
                //this.txtidEmpleado.Text = this.objCausante.id_Empleado.ToString();
                //this.txtResponsable.Text = this.objCausante.Responsable;
                this.txtObservaciones.Text = this.objCausante.Observaciones;
                //    if (this.objCausante.Foto != null)
                //    {
                //        byte[] Imagen = this.objCausante.Foto;
                //        MemoryStream objMemoryStream = new MemoryStream(Imagen);
                //        this.imgFoto.Image = Image.FromStream(objMemoryStream);
                //    }
                //    else { this.imgFoto.Image = null; }
            }
        }
        public _00012_Traslado_ExternoJardin()
        {
        }
        public void cargarCodigoCem()
        {
            try
            {
                //Nomenc objNomencOeste = new Nomenc();
                //objNomencOeste.CodNomenc = 1;
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
        //public void cargarTramite()
        //{
        //    try
        //    {
        //        Tramite objTramite = new Tramite();
        //        objTramite.id_TipoTramite = 2;//1=inhumacion
        //        cmbTramite.ValueMember = "id_Tramite";
        //        cmbTramite.DisplayMember = "Tramite_Tipo";
        //        cmbTramite.DataSource = objTramite.MostrarTodos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

        public void cargarEmpresas()
        {
            try
            {
                this.cmbEmpresa.ValueMember = "id_Empresa";
                this.cmbEmpresa.DisplayMember = "Nombre_Emp";
                this.cmbEmpresa.DataSource = new Empresa().MostrarTodos();
                this.cmbEmpresa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarOtroCem()
        {
            try
            {
                this.cmbTraslado.ValueMember = "id_OtroCem";
                this.cmbTraslado.DisplayMember = "OtroCem";
                this.cmbTraslado.DataSource = new Cement_Externo().MostrarTodos();//usando la clase 
                this.cmbTraslado.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.objTraslado.Dni = this.txtDni.Text;
                this.objTraslado.Nombre = this.txtNombreCuerpo.Text;
                this.objTraslado.Codcem = this.cmbCodCem.ValueMember;
                this.objTraslado.Seccion = this.txtSeccion.Text;
                this.objTraslado.Cuadro = this.txtCuadro.Text;
                this.objTraslado.Zona = this.txtZona.Text;
                this.objTraslado.Lote = this.txtLote.Text;
                this.objTraslado.OtroCem = this.cmbTraslado.Text;
                //this.objTraslado.TamNicho = this.txtTamNicho.Text;
                //this.objTraslado.Nicho_Numero = this.txtNicho_Numero.Text;                
                this.objTraslado.Nombre = this.txtNombreCuerpo.Text;
                this.objTraslado.Observaciones = this.txtObservaciones.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.objTraslado.id_Nomenc = (int)this.cmbCodCem.SelectedValue;
            this.objTraslado.Codcem = this.cmbCodCem.Text;

            //this.objTraslado.Galeria = this.cmbGaleria.Text;

            this.objCausante.id_Empresa = Convert.ToInt32(this.cmbEmpresa.SelectedValue);
            this.objTraslado.Nombre_Emp = this.cmbEmpresa.Text;

            this.objCausante.id_Construccion = Convert.ToInt32(this.cmbTipoConst.SelectedValue);

            //this.objCausante.id_Tramite = Convert.ToInt32(this.cmbTramite.SelectedValue);

            this.objTraslado.Fecha_Traslado = this.cmbFechaTrasl.Value;

            if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
            {
            }


            if (!string.IsNullOrEmpty(this.objExterno.ToString()))
            {
                this.objExterno.Nombre_OtroCem = this.cmbTraslado.ValueMember;//cuando se deja vacia la funcion convert.Toint32, no se puede convertir un vacío a numero, hay que condicionarlo.
            }

            int resultado = this.objTraslado.InsertarActualizar();
            if (resultado == 1)
            {

                MessageBox.Show("Registro Guardado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

            }
            else if (resultado == 2)
            {
                MessageBox.Show("Registro Trasladado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                this.objNomencCausante = this.objCausante.NomencCausante;
                this.objNomencCausante.Estado = false;

                //this.objHistorico = this.objCausante.Historico;
                //this.objTraslado.Estado = false; ---Pone en falso el registro para que no aparezca en el grid
                //this.objTraslado.InsertarActualizar();
                //this.objNomencCausante.Eliminar(); ----Hace un UPDATE para sobreescribir el registro a esconder con el borrado logico

            }
            else
            {
                MessageBox.Show("No es posible el Causante en el Equipo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                private void Limpiar()
        {
            this.txtSeccion.Clear();
            this.txtCuadro.Clear();
            this.txtZona.Clear();
            //this.txtTamNicho.Clear();
            //this.txtNicho_Numero.Clear();
            this.txtLote.Clear();
            this.txtFolio.Clear();
            this.txtNombreCuerpo.Clear();
            this.txtDni.Clear();
            this.txtEdad.Clear();
            //this.txtMeses.Clear();
            this.txtNacionalidad.Clear();
            ////this.txtResponsable.Clear();
            ////this.txtEmpNumAfil.Clear();
            this.txtObservaciones.Clear();
        }

        private void btnNuevoCem_Click(object sender, EventArgs e)
        {
            _00013_Nuevo_Cement objForm = new _00013_Nuevo_Cement(new Cement_Externo());
            objForm.ShowDialog();
            CargarOtroCem();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            _00004_Empresa_N NewTipo = new _00004_Empresa_N();

            NewTipo.ShowDialog();

            cargarEmpresas();
        }
        private void ActivarDesactivarControles()
        {
            //if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Nicho")
            //{

            //    //txtNicho_Numero.Enabled = true;
            //    //txtTamNicho.Enabled = true;
            //    //txtGaleria.Enabled = true;
            //    //txtEstado.Enabled = true;
            //    txtSeccion.Enabled = false;
            //    txtZona.Enabled = false;
            //    txtCuadro.Enabled = false;
            //    txtLote.Enabled = false;
            //}
            //else
            //{
            //    //txtNicho_Numero.Enabled = false;
            //    //txtTamNicho.Enabled = false;
            //    //txtGaleria.Enabled = false;
            //    //txtEstado.Enabled = false;
            //    txtZona.Enabled = true;
            //    txtCuadro.Enabled = true;
            //    txtLote.Enabled = true;
            //}


            if (cmbCodCem.Text == "JARDIN" && cmbTipoConst.Text == "Sepultura")
            {
                txtSeccion.Enabled = true;
                //txtGaleria.Enabled = false;
                //txtTamNicho.Enabled = false;
                //txtNicho_Numero.Enabled = false;
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
        private void LimpiarCampos()
        {
            if (this.cmbCodCem.Text == "OESTE")
            {
                Limpiar();
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

        private void cmbCodCem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
                ActivarDesactivarControles();
            }
            catch (Exception ex)
            { }
        }

        private void cmbTipoConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
                ActivarDesactivarControles();
            }
            catch (Exception ex)
            { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.objCausante.Eliminar();
                MessageBox.Show("Registro Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _00002_CausanteJardin objCaus = new _00002_CausanteJardin();
                objCaus.txtBusqueda.Clear();
                this.objCausante.MostrarTodos();
            }
        }

        private void cmbCodCem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }
        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                int lotemaximo = 40;
                if (cmbCodCem.Text == "JARDIN" && cmbTipoConst.Text == "Sepultura") //si esta vacío no hará nada.
                {

                    int numeroactualjardin = Convert.ToInt32(txtLote.Text);
                    if (numeroactualjardin > lotemaximo)
                    {
                        MessageBox.Show("el número ingresado no puede ser mayor a 40");
                        txtLote.Focus();
                    }
                }
            }
            catch
            { }

            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtLote_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLote.Text))
                {
                    MessageBox.Show("El Lote no puede estar vacio");
                    e.Cancel = true;
                }
                int lotemaximo = 584;
                int loteactual = Convert.ToInt32(txtLote.Text);
                if (loteactual > lotemaximo)
                {
                    MessageBox.Show("el número ingresado no puede ser mayor a 584");
                    txtLote.Clear();
                    txtLote.Focus();
                }
            }
            catch { }
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtNombreCuerpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void txtCuadro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48) { e.Handled = true; return; }
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtCuadro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int cuadromaximooeste = 8;
                int numeroactualoeste = Convert.ToInt32(txtCuadro.Text);

                if (cmbCodCem.Text == "JARDIN" && numeroactualoeste > cuadromaximooeste)
                {
                    MessageBox.Show("el número ingresado no debe ser mayor a 8");
                    txtCuadro.Clear();
                    txtCuadro.Focus();
                }

            }
            catch
            { }
        }

        private void txtCuadro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCuadro.Text)) //si esta vacío no hará nada.
                {
                    MessageBox.Show("El cuadro no puede estar vacio");
                    e.Cancel = true;
                }

                int cuadromaximonorte = 87;
                int numeroactualnorte = Convert.ToInt32(txtCuadro.Text);
                if (cmbCodCem.Text == "NORTE" && numeroactualnorte > cuadromaximonorte)
                {
                    MessageBox.Show("el número ingresado no puede ser mayor a  87");
                    txtCuadro.Clear();
                    txtCuadro.Focus();
                }
            }
            catch
            { }
        }

        private void txtZona_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int limitemaximo = 3;

                if (string.IsNullOrEmpty(txtZona.Text))
                {
                    MessageBox.Show("La zona no puede estar vacia");
                    e.Cancel = true;
                }

                int numeroactual = Convert.ToInt32(txtZona.Text);
                if (numeroactual > limitemaximo)
                {
                    MessageBox.Show("La zona ingresada no debe ser mayor a 3");
                    txtZona.Clear();
                    e.Cancel = true;
                }
            }
            catch
            { }
        }

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int limiteEdad = 0;
                int limiteEdad2 = 122;
                int limiteactualEdad = Convert.ToInt32(txtEdad.Text);
                if (string.IsNullOrEmpty(txtEdad.Text))
                {
                    //txtMeses.Enabled = true;
                    MessageBox.Show("La Edad no puede estar vacia");
                    e.Cancel = true;
                    return;
                }
                if (limiteactualEdad > limiteEdad)
                {
                    //txtMeses.Enabled = false;
                    SexoF.Focus();
                }
                if (limiteactualEdad > limiteEdad2)
                {
                    MessageBox.Show("La cantidad de años supera el límite permitido");
                    txtEdad.Clear();
                    e.Cancel = true;
                    return;
                }
            }

            catch { }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDni.Text)) { return; }
            if (!string.IsNullOrEmpty(this.objCausante.ToString())) { return; }
            Causante objCausanteDNI = new Causante();
            objCausanteDNI.Dni = txtDni.Text;
            objCausanteDNI.Seleccionar();
            if (!string.IsNullOrEmpty(objCausanteDNI.ToString()))
            {
                MessageBox.Show("Este cuerpo ya fue trasladado.");
                e.Cancel = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int limiteEdad2 = 122;
                int limiteactualEdad2 = Convert.ToInt32(txtEdad.Text);

                if (limiteactualEdad2 > limiteEdad2)
                {
                    MessageBox.Show("La cantidad de años supera el límite permitido");
                    txtEdad.Clear();
                    txtEdad.Focus();
                    return;
                }
            }
            catch { }

            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtEdad.Enabled = true;
            //txtMeses.Enabled = true;
        }

        private void cmbFechaInhuma_Validating(object sender, CancelEventArgs e)
        {
            DateTime FechaFallec = Convert.ToDateTime(cmbFechaFallec.Value.ToShortDateString());
            DateTime FechaInhuma = Convert.ToDateTime(cmbFechaInhuma.Value.ToShortDateString());
            if (FechaFallec > FechaInhuma)
            {
                MessageBox.Show("la fecha de inhumación es mayor a la fecha de fallecido.");
                e.Cancel = true;
            }
        }
        Cement_Externo objExterno = new Cement_Externo();

        private void cmbTraslado_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void _00012_Traslado_ExternoJardin_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

