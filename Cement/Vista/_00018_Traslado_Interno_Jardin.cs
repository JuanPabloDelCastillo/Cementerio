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
    public partial class _00018_Traslado_Interno_Jardin : Form
    {
        private Nomenc objNomenc = new Nomenc();
        private Causante objCausante = new Causante();
        private TrasladoInt objTrasladoInt = new TrasladoInt();
        public _00018_Traslado_Interno_Jardin(Causante paramCausante)
        {
            InitializeComponent();
            this.objCausante = paramCausante;// asignando el parametro de clase causante con la variable de la misma clase.
            cargarCodigoCem();
            cargarTramiteInt();
            cargarEmpresas();
            cargarCemInt();
            //cargarConst_TipoInt();
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
                if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
                {
                    this.txtCuadro.Text = this.objCausante.NomencCausante.Cuadro;
                    this.txtZona.Text = this.objCausante.NomencCausante.Zona;
                    this.txtLote.Text = this.objCausante.NomencCausante.Lote;
                    this.txtSeccion.Text = this.objCausante.NomencCausante.Seccion;
                }
                if (this.objCausante.Nicho != null)
                {
                    this.txtNicho_Numero.Text = this.objCausante.Nicho.NumeroNicho;
                    this.txtTamNicho.Text = this.objCausante.Nicho.TamanoNicho.TamanoNichoT;
                    this.txtGaleria.Text = this.objCausante.Nicho.Galeria.GaleriaN;
                    this.txtEstado.Text = this.objCausante.Nicho.EstadoNicho.EstadoNichos;
                }

                this.cmbTramiteInt.SelectedValue = this.objCausante.id_Tramite;
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
                //this.txtMeses.Text = this.objCausante.Edad_Meses;
                this.txtNacionalidad.Text = this.objCausante.Nacionalidad;
                this.cmbFechaFallec.Value = this.objCausante.FechaHora_Fall;
                this.cmbFechaInhuma.Value = this.objCausante.Fecha_Inhum;
                this.txtidEmpleado.Text = this.objCausante.id_Empleado.ToString();
                //this.txtResponsable.Text = this.objCausante.Responsable;
                this.txtObservaciones.Text = this.objCausante.Observaciones;
            }

        }


        public _00018_Traslado_Interno_Jardin()
        {
        }
        public void cargarCodigoCem()
        {
            try
            {
                //Nomenc objNomencJardin = new Nomenc();
                //objNomencJardin.CodNomenc = 3;
                //this.cmbCodCem.ValueMember = "id_Nomenc";
                //this.cmbCodCem.DisplayMember = "Codcem";
                //this.cmbCodCem.DataSource = objNomencJardin.MostrarTodos();//usando la clase nomenc
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
        public void cargarConst_Tipo(int id_Nomenc)
        {
            try
            {
                Construcc_Tipo objConstrucc_Tipo = new Construcc_Tipo();
                objConstrucc_Tipo.id_Nomenc = id_Nomenc;
                this.cmbTipoConst.ValueMember = "id_Construccion";
                this.cmbTipoConst.DisplayMember = "Nombre_C";
                this.cmbTipoConst.DataSource = objConstrucc_Tipo.MostrarTodos();
                this.cmbTipoConst.SelectedIndex = -1;

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

        public void cargarCemInt()
        {
            try
            {
                //Nomenc objNomenc = new Nomenc();
                //objNomenc.id_Nomenc = 1;
                this.cmbCemInt.ValueMember = "id_Nomenc";
                this.cmbCemInt.DisplayMember = "Codcem";
                this.cmbCemInt.DataSource = new Nomenc().MostrarReporte();//usando la clase nomenc
                this.cmbCemInt.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cargarTramiteInt()
        {
            try
            {
                Tramite objTramiteInt = new Tramite();
                objTramiteInt.id_TipoTramite = 3;//3 = TRASLADO INTERNO
                cmbTramiteInt.ValueMember = "id_Tramite";
                cmbTramiteInt.DisplayMember = "Tramite_Tipo";
                cmbTramiteInt.DataSource = objTramiteInt.MostrarTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cargarConst_TipoInt(int id_Nomenc)
        {
            try
            {
                Construcc_Tipo objConstrucc_TipoInt = new Construcc_Tipo();
                objConstrucc_TipoInt.id_Nomenc = id_Nomenc;
                this.cmbTipoConstInt.ValueMember = "id_Construccion";
                this.cmbTipoConstInt.DisplayMember = "Nombre_C";
                this.cmbTipoConstInt.DataSource = objConstrucc_TipoInt.MostrarTodos();
                cmbTipoConstInt.SelectedIndex = -1;

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
                cargarConst_Tipo((int)this.cmbCodCem.SelectedValue);
            }
            catch (Exception ex)
            { }
        }

        private void cmbTipoConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ActivarDesactivarControlesInt();
        }
        private void ActivarDesactivarControlesInt()
        {
            if (cmbCemInt.Text == "NORTE" && cmbTipoConstInt.Text == "Nicho")
            {
                //Limpiar();
                txtNNumNicho.Enabled = true;
                txtNTamNicho.Enabled = true;
                txtNGaleria.Enabled = true;
                txtNEstado.Enabled = true;
                txtNSeccion.Enabled = false;
                txtNZona.Enabled = true;
                txtNCuadro.Enabled = false;
                txtNLote.Enabled = false;

            }
            else
            {
                txtNNumNicho.Enabled = false;
                txtNTamNicho.Enabled = false;
                txtNGaleria.Enabled = false;
                txtNEstado.Enabled = false;
                txtNSeccion.Enabled = false;
                txtNZona.Enabled = true;
                txtNCuadro.Enabled = true;
                txtNLote.Enabled = true;
            }


            if (cmbCemInt.Text == "JARDIN" && cmbTipoConstInt.Text == "Sepultura")
            {
                txtNNumNicho.Enabled = false;
                txtNTamNicho.Enabled = false;
                txtNGaleria.Enabled = false;
                txtNEstado.Enabled = false;
                txtNSeccion.Enabled = true;
                txtNZona.Enabled = true;
                txtNCuadro.Enabled = true;
                txtNLote.Enabled = true;
            }
            else
            {
                txtSeccion.Enabled = false;

            }
            //    LimpiarCampos();
        }

        private void cmbCemInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarConst_TipoInt((int)this.cmbCemInt.SelectedValue);
            ActivarDesactivarControlesInt();
        }

        private void cmbTipoConstInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarDesactivarControlesInt();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.objTrasladoInt.Dni = this.txtDni.Text;
                this.objTrasladoInt.Nombre = this.txtNombreCuerpo.Text;
                this.objTrasladoInt.Codcem = this.cmbCodCem.ValueMember;
                this.objTrasladoInt.id_Construccion = Convert.ToInt32(this.cmbTipoConst.SelectedValue);
                this.objTrasladoInt.id_NConstrucc = Convert.ToInt32(this.cmbTipoConstInt.SelectedValue);
                this.objTrasladoInt.Seccion = this.txtSeccion.Text;
                this.objTrasladoInt.Cuadro = this.txtCuadro.Text;
                this.objTrasladoInt.Zona = this.txtZona.Text;
                this.objTrasladoInt.Lote = this.txtLote.Text;
                this.objTrasladoInt.Nombre = this.txtNombreCuerpo.Text;
                this.objTrasladoInt.N_Codcem = this.cmbCemInt.Text;
                this.objTrasladoInt.N_Cuadro = this.txtNCuadro.Text;
                this.objTrasladoInt.N_Zona = this.txtNZona.Text;
                this.objTrasladoInt.N_Lote = this.txtNLote.Text;
                this.objTrasladoInt.N_Seccion = this.txtNSeccion.Text;
                this.objTrasladoInt.TamNicho = this.txtTamNicho.Text;
                //this.objCausante.Nicho.NumeroNicho = this.txtNicho_Numero.Text;
                this.objTrasladoInt.Nicho_Numero = this.txtNicho_Numero.Text;

                this.objTrasladoInt.Observaciones = this.txtObservaciones.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.objTrasladoInt.id_Nomenc = (int)this.cmbCodCem.SelectedValue;
            this.objTrasladoInt.Codcem = this.cmbCodCem.Text;

            //this.objTraslado.Galeria = this.cmbGaleria.Text;

            this.objCausante.id_Empresa = Convert.ToInt32(this.cmbEmpresa.SelectedValue);
            this.objTrasladoInt.Nombre_Emp = this.cmbEmpresa.Text;

            this.objCausante.id_Construccion = Convert.ToInt32(this.cmbTipoConst.SelectedValue);
            this.objTrasladoInt.Nombre_C = this.cmbTipoConst.Text;

            this.objCausante.id_NConstrucc = Convert.ToInt32(this.cmbTipoConstInt.SelectedValue);
            this.objTrasladoInt.NCNombre = this.cmbTipoConstInt.Text;

            this.objCausante.id_Tramite = Convert.ToInt32(this.cmbTramiteInt.SelectedValue);

            this.objTrasladoInt.Fecha_TrasladoInt = this.cmbFechaTrasladoInt.Value;

            if (!string.IsNullOrEmpty(this.objCausante.NomencCausante.ToString()))
            {
            }


            //if (!string.IsNullOrEmpty(this.objExterno.ToString()))
            //{
            //    this.objExterno.Nombre_OtroCem = this.cmbTraslado.ValueMember;//cuando se deja vacia la funcion convert.Toint32, no se puede convertir un vacío a numero, hay que condicionarlo.
            //}

            int resultado = this.objTrasladoInt.InsertarActualizar();
            if (resultado == 1)
            {
                MessageBox.Show("Registro Guardado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Registro Trasladado Correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No es posible el Causante en el Equipo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtNCuadro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtNZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtNLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
            btnGuardar.Enabled = true;
        }

        private void _00018_Traslado_Interno_Jardin_Load(object sender, EventArgs e)
        {
            cargarTramiteInt();
        }

        private void txtNNumNicho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNTamNicho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNGaleria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

