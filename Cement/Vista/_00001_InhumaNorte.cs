using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Cement.Vista
{
    public partial class _00001_InhumaNorte : Form
    {
        Nicho objNicho = new Nicho();
        EstadoNicho objEstadoNicho = new EstadoNicho();
        TamanoNicho objTamanoNicho = new TamanoNicho();
        Galeria objGaleria = new Galeria();
        private Causante objCausante = new Causante();
        private NomencCausante objNomencCausante = new NomencCausante();

        //Constructor, es lo primero que se inicia cuando la clase se instancia.
        public _00001_InhumaNorte(Causante paramCausante)
        {
            InitializeComponent();
            this.objCausante = paramCausante;// asignando el parametro de clase causante con la variable de la misma clase.

            cargarCodigoCem();
            cargarTramite();
            cargarEmpresas();
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

                //this.txtNicho_Numero.Text = this.objCausante.NumeroNicho;
                //this.txtTamNicho.Text = objCausante.Nicho.TamanoNicho.TamanoNichoT;
                //this.txtGaleria.Text = objCausante.Nicho.Galeria.GaleriaN;
                //this.txtEstado.Text = objCausante.Nicho.EstadoNicho.EstadoNichos;

                //if (this.objCausante.Nicho != null)
                //{

                    this.txtNicho_Numero.Text = this.objCausante.Nicho.NumeroNicho;
                    this.txtTamNicho.Text = this.objCausante.Nicho.TamanoNicho.TamanoNichoT;
                    this.txtGaleria.Text = this.objCausante.Nicho.Galeria.GaleriaN;
                    this.txtEstado.Text = this.objCausante.Nicho.EstadoNicho.EstadoNichos;
                //}

                this.cmbTramite.SelectedValue = this.objCausante.id_Tramite;
                if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
                {
                    this.txtCuadro.Text = this.objCausante.NomencCausante.Cuadro;
                    this.txtZona.Text = this.objCausante.NomencCausante.Zona;
                    this.txtLote.Text = this.objCausante.NomencCausante.Lote;
                    this.txtSeccion.Text = this.objCausante.NomencCausante.Seccion;
                }
                this.txtFolio.Text = this.objCausante.Folio;
                this.txtNombreCuerpo.Text = this.objCausante.Nombre;
                this.txtDni.Text = this.objCausante.Dni;
                this.txtEdad.Text = this.objCausante.Edad;
                this.txtNacionalidad.Text = this.objCausante.Nacionalidad;
                this.cmbFechaFallec.Value = this.objCausante.FechaHora_Fall;
                this.cmbFechaInhuma.Value = this.objCausante.Fecha_Inhum;
                this.txtObservaciones.Text = this.objCausante.Observaciones;
                if (this.objCausante.Foto != null)
                {
                    byte[] Imagen = this.objCausante.Foto;
                    MemoryStream objMemoryStream = new MemoryStream(Imagen);
                    this.imgFoto.Image = Image.FromStream(objMemoryStream);
                }
                else { this.imgFoto.Image = null; }
            }
        }

        public _00001_InhumaNorte()
        {
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
                //cmbCodCem.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarTramite()
        {
            try
            {
                Tramite objTramite = new Tramite();
                objTramite.id_TipoTramite = 1;//1=inhumacion
                cmbTramite.ValueMember = "id_Tramite";
                cmbTramite.DisplayMember = "Tramite_Tipo";
                cmbTramite.DataSource = objTramite.MostrarTodos();
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

        private void Limpiar()
        {
            this.txtSeccion.Clear();
            this.txtCuadro.Clear();
            this.txtZona.Clear();
            this.txtTamNicho.Clear();
            this.txtNicho_Numero.Clear();
            this.txtLote.Clear();
            this.txtFolio.Clear();
            this.txtNombreCuerpo.Clear();
            this.txtDni.Clear();
            this.txtEdad.Clear();
            //this.txtMeses.Clear();
            this.txtNacionalidad.Clear();
            //this.txtResponsable.Clear();
            //this.txtEmpNumAfil.Clear();
            this.txtObservaciones.Clear();
        }

        ////////////EVENTO PARA CARGAR FOTO /////////////////
        private void imgFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objopenFileDialog = new OpenFileDialog();

                objopenFileDialog.Filter = "Imágenes png|*.png";

                if (objopenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.imgFoto.Load(objopenFileDialog.FileName);
                }
                else
                {
                    this.imgFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }
        //////////////////////////////////////////////////////

        private void btnNuevoCement_Click(object sender, EventArgs e)
        {
            _00003_Cement_Tipo objForm = new _00003_Cement_Tipo(new Nomenc());
            objForm.ShowDialog();
            cargarCodigoCem();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            _00004_Empresa_N NewTipo = new _00004_Empresa_N();

            NewTipo.ShowDialog();

            cargarEmpresas();
        }
        private void DesactivaTxt()
        {
            txtF2.Enabled = false;
            txtNicho_Numero.Enabled = false;
            txtTamNicho.Enabled = false;
            txtGaleria.Enabled = false;
            txtEstado.Enabled = false;
            txtSeccion.Enabled = false;
            txtZona.Enabled = false;
            txtCuadro.Enabled = false;
            txtLote.Enabled = false;
            txtFolio.Enabled = false;
            txtNombreCuerpo.Enabled = false;
            txtDni.Enabled = false;
            txtEdad.Enabled = false;
            //txtMeses.Enabled = false;
            txtNacionalidad.Enabled = false;
        }
        private void ActivarDesactivarControles()
        {
            if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Nicho")
            {
                //Limpiar();
                this.txtF2.Focus();
                txtF2.Enabled = true;
                txtF2.ReadOnly = true;
                txtNicho_Numero.Enabled = true;
                txtTamNicho.Enabled = true;
                txtGaleria.Enabled = true;
                txtEstado.Enabled= true;
                txtSeccion.Enabled = false;
                txtZona.Enabled = false;
                txtCuadro.Enabled = false;
                txtLote.Enabled = false;
                txtFolio.Enabled = false;
                txtNombreCuerpo.Enabled = true;
                txtDni.Enabled = true;
                txtEdad.Enabled = true;
                txtNacionalidad.Enabled = true;
            }
            else
            {
                txtF2.Enabled = false;
                txtNicho_Numero.Enabled = false;
                txtTamNicho.Enabled = false;
                txtGaleria.Enabled = false;
                txtEstado.Enabled = false;
                txtSeccion.Enabled = false;
                txtCuadro.Focus();
                txtCuadro.Enabled = true;
                txtZona.Enabled = true;
                txtLote.Enabled = true;
                txtFolio.Enabled = true;
                txtNombreCuerpo.Enabled = true;
                txtDni.Enabled = true;
                txtEdad.Enabled = true;
                txtNacionalidad.Enabled = true;

            }
    
    }
    




    private void cmbCodCem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
                ActivarDesactivarControles();
            }
            catch (Exception ex)
            { }
        }


        private void cmbTipoConst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (cmbTipoConst.Text == "Noria")
            //{
            //    ErrorProvider.Equals(cmbTipoConst, MessageBox.Show("Items Inhabilitado para Inhumaciones", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information));
            //    Application.DoEvents();
            //    cmbTipoConst.SelectedIndex = -1;
            //}
            ActivarDesactivarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.objCausante.Eliminar();
                MessageBox.Show("Registro Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _00002_Causante objCaus = new _00002_Causante();
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

   //??
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

        private void cmbEmpresa_Leave(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = true;
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
        private void txtCuadro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int cuadromaximooeste = 8;
                int numeroactualoeste = Convert.ToInt32(txtCuadro.Text);

                if (cmbCodCem.Text == "OESTE" && numeroactualoeste > cuadromaximooeste)
                {
                    MessageBox.Show("el número ingresado no debe ser mayor a 8");
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
                MessageBox.Show("El DNI ingresado ya existe.");
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

        //private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
        //    if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
        //    if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
        //    if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
        //    e.Handled = false;
        //}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtEdad.Enabled = true;
            //txtMeses.Enabled = true;

        }

        private void txtNicho_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SexoF.Checked == true)
                {
                    this.objCausante.Sexo = "F";
                }
                else
                {
                    this.objCausante.Sexo = "M";
                }
                this.objCausante.Folio = this.txtFolio.Text;
                this.objCausante.Nombre = this.txtNombreCuerpo.Text;
                this.objCausante.Dni = this.txtDni.Text;
                this.objCausante.Edad = this.txtEdad.Text;
                this.objCausante.Nacionalidad = this.txtNacionalidad.Text;
                this.objCausante.FechaHora_Fall = this.cmbFechaFallec.Value;
                this.objCausante.Fecha_Inhum = this.cmbFechaInhuma.Value;
                this.objNicho.NumeroNicho = txtNicho_Numero.Text;
                this.objTamanoNicho.TamanoNichoT = txtTamNicho.Text;
                this.objGaleria.GaleriaN = this.txtGaleria.Text;
                this.objEstadoNicho.EstadoNichos = txtEstado.Text;


                if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
                {
                }


                //if (!string.IsNullOrEmpty(this.txtidEmpleado.Text))
                //{
                //    this.objCausante.CODIGO = Convert.ToInt32(this.txtidEmpleado.Text);//cuando se deja vacia la funcion convert.Toint32, no se puede convertir un vacío a numero, hay que condicionarlo.
                //}
                //this.objCausante.Responsable = this.txtResponsable.Text;

                this.objCausante.Observaciones = this.txtObservaciones.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //validaciones

            if (this.cmbCodCem.SelectedValue == null)
            {
                MessageBox.Show("Seleccionar el Cementerio", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbCodCem.Focus();
                return;
            }


            if (this.cmbTipoConst.SelectedValue == null)
            {
                MessageBox.Show("Seleccionar el Tipo de Construcción", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbTipoConst.Focus();
                return;
            }

            /////////////////////////

            if (this.cmbTipoConst.Text != "Nicho")
            {
                if (string.IsNullOrEmpty(txtCuadro.Text))
                {
                    MessageBox.Show("El cuadro no puede estar vacío");
                    txtCuadro.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtZona.Text))

                {
                    MessageBox.Show("La Zona no puede estar vacía");
                    txtLote.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtLote.Text))

                {
                    MessageBox.Show("El Lote no puede estar vacío");
                    txtLote.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtFolio.Text))
                {
                    MessageBox.Show("El Folio no puede estar vacío");
                    txtFolio.Focus();
                    return;
                }
            }
            ////////////////////////


            if (string.IsNullOrEmpty(txtNombreCuerpo.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacio");
                txtNombreCuerpo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("El Dni no puede estar vacio");
                txtDni.Focus();
                return;
            }


            this.objCausante.id_Nomenc = Convert.ToInt32(this.cmbCodCem.SelectedValue);
            this.objCausante.id_Empresa = Convert.ToInt32(this.cmbEmpresa.SelectedValue);
            this.objCausante.id_Construccion = Convert.ToInt32(this.cmbTipoConst.SelectedValue);

            if (this.cmbEmpresa.SelectedValue != null)
            {
                if (!string.IsNullOrEmpty(this.cmbEmpresa.SelectedValue.ToString()))
                {
                    this.objCausante.id_Empresa = Convert.ToInt32(this.cmbEmpresa.SelectedValue);
                }
            }

            this.objCausante.id_Tramite = Convert.ToInt32(this.cmbTramite.SelectedValue);

            ////////////GUARDAMOS LA FOTO EN UNA VARIABLE DE MEMORIA
            MemoryStream objMemoryStream = new MemoryStream();
            if (this.imgFoto.Image != null)
            {
                this.imgFoto.Image.Save(objMemoryStream, ImageFormat.Png);
                this.objCausante.Foto = objMemoryStream.GetBuffer();
            }
            else { this.objCausante.Foto = null; }
            ////////////////////////////////////////////////////////////

            int resultado = this.objCausante.InsertarActualizar();
            if (resultado == 1)
            {
                MessageBox.Show("Registro Guardado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Registro Actualizado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No es posible el Causante en el Equipo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this.cmbCodCem.SelectedValue != null)
            {
                if (!string.IsNullOrEmpty(this.cmbCodCem.SelectedValue.ToString()))
                {
                    if (resultado == 1 || resultado == 2)
                    {
                        //
                        this.objNomencCausante.id_Nomenc = (int)this.cmbCodCem.SelectedValue;
                        this.objNomencCausante.Dni = this.objCausante.Dni;
                        this.objNomencCausante.Seleccionar();
                        //
                        this.objNomencCausante.Codcem = this.cmbCodCem.Text;

                        //????
                        //if (!string.IsNullOrEmpty(this.txtNicho_Numero.Text))
                        //{
                        //    this.objNicho.NumeroNicho = this.txtNicho_Numero.Text;
                        //    this.objTamanoNicho.TamanoNichoT = this.txtTamNicho.Text;
                        //    this.objGaleria.GaleriaN = this.txtGaleria.Text;
                        //    this.objEstadoNicho.EstadoNichos = this.txtEstado.Text;
                        //}

                        //???

                    }



                        if (!string.IsNullOrEmpty(this.txtSeccion.Text))
                        {
                            this.objNomencCausante.Seccion = this.txtSeccion.Text;
                        }
                        if (!string.IsNullOrEmpty(this.txtCuadro.Text))
                        {
                            this.objNomencCausante.Cuadro = this.txtCuadro.Text;
                        }
                        if (!string.IsNullOrEmpty(this.txtZona.Text))
                        {
                            this.objNomencCausante.Zona = this.txtZona.Text;
                        }
                        if (!string.IsNullOrEmpty(this.txtLote.Text))
                        {
                            this.objNomencCausante.Lote = this.txtLote.Text;
                        }

                        this.objNomencCausante.Estado = true;
                        int resultadonomec = objNomencCausante.InsertarActualizar();
                        //aqui se puede evaluar el resultado.
                    }
                }
        }

        ////////////EVENTO PARA CARGAR FOTO /////////////////
        private void imgFoto_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objopenFileDialog = new OpenFileDialog();

                objopenFileDialog.Filter = "Imágenes png|*.png";

                if (objopenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.imgFoto.Load(objopenFileDialog.FileName);
                }
                else
                {
                    this.imgFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }
        //////////////////////////////////////////////////////
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.objNomencCausante = this.objCausante.NomencCausante;
                this.objNomencCausante.Estado = false;
                this.objNomencCausante.Eliminar();
                MessageBox.Show("Registro Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _00002_CausanteNorte objCaus = new _00002_CausanteNorte();
                objCaus.txtBusqueda.Clear();
                this.objCausante.MostrarTodos();
            }
        }

        private void _00001_InhumaNorte_Load(object sender, EventArgs e)
        {
            DesactivaTxt();
            ActivarDesactivarControles();
        }

        private void txtF2_KeyDown(object sender, KeyEventArgs e)
        {
            //linea de codigo para que al presionar enter, se cambie a tab.
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }

            if (e.KeyValue == (char)Keys.F2)
            {
                _00014_Nichos_Registrados objRegist = new _00014_Nichos_Registrados();

                if (objRegist.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    this.txtNicho_Numero.Text = objRegist.dgvNichos.CurrentRow.Cells["ColumnNumeroNicho"].Value.ToString();
                    //this.txtGaleria.Tag = objRegist.dgvNichos.CurrentRow.Cells["ColumnIdGaleria"].Value.ToString();
                    this.txtTamNicho.Text = objRegist.dgvNichos.CurrentRow.Cells["ColumnTamanoNicho"].Value.ToString();
                    this.txtGaleria.Text = objRegist.dgvNichos.CurrentRow.Cells["ColumnGaleria"].Value.ToString();
                    this.txtEstado.Text = objRegist.dgvNichos.CurrentRow.Cells["ColumnEstadoNichos"].Value.ToString();
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




