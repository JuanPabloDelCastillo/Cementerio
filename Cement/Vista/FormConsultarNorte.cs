using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cement.Vista
{
    public partial class FormConsultarNorte : Form
    {
        private Causante objCausante = new Causante();
        private TrasladoExt objTraslado = new TrasladoExt();
        private Nicho objNicho = new Nicho();
        public FormConsultarNorte(Causante paramCausante)
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
                    this.txtNCuadro.Text = this.objCausante.NomencCausante.Cuadro;
                    this.txtNZona.Text = this.objCausante.NomencCausante.Zona;
                    this.txtNLote.Text = this.objCausante.NomencCausante.Lote;
                    this.txtSeccion.Text = this.objCausante.NomencCausante.Seccion;
                }

                if (this.objCausante.Nicho != null)
                {
                    this.txtNNumNicho.Text = this.objCausante.Nicho.NumeroNicho;
                    this.txtNTamNicho.Text = this.objCausante.Nicho.TamanoNicho.TamanoNichoT;
                    this.txtNGaleria.Text = this.objCausante.Nicho.Galeria.GaleriaN;
                    //this.txtEstado.Text = this.objCausante.Nicho.EstadoNicho.EstadoNichos;
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
                //    if (this.objCausante.Foto != null)
                //    {
                //        byte[] Imagen = this.objCausante.Foto;
                //        MemoryStream objMemoryStream = new MemoryStream(Imagen);
                //        this.imgFoto.Image = Image.FromStream(objMemoryStream);
                //    }
                //    else { this.imgFoto.Image = null; }
            }
        }
        public FormConsultarNorte()
        { }

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
                this.cmbTraslado.DataSource = new Nomenc().MostrarReporte();
                //this.cmbTraslado.DataSource = new Cement_Externo().MostrarTodos();//usando la clase                
                this.cmbTraslado.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Consulta_Norte objNorte = new Consulta_Norte();
            objNorte.dgvCausante.DataSource = this.objCausante.MostrarCausantesNorte();
            this.Close();
        }

        private void FormConsultarNorte_Load(object sender, EventArgs e)
        {
            //this.dgvCausante.DataSource = this.objCausante.MostrarTodos();
        }

        private void ActivarDesactivarControlesInt()
        {
            if (cmbCodCem.Text == "NORTE" && cmbTipoConst.Text == "Nicho")
            {
                //Limpiar();
                txtNNumNicho.Enabled = true;
                txtNTamNicho.Enabled = true;
                txtNGaleria.Enabled = true;
                //txtNEstado.Enabled = true;
                txtSeccion.Enabled = false;
                txtNZona.Enabled = false;
                txtNCuadro.Enabled = false;
                txtNLote.Enabled = false;

            }
            else
            {
                txtNNumNicho.Enabled = false;
                txtNTamNicho.Enabled = false;
                txtNGaleria.Enabled = false;
                //txtNEstado.Enabled = false;
                txtSeccion.Enabled = false;
                txtNZona.Enabled = true;
                txtNCuadro.Enabled = true;
                txtNLote.Enabled = true;
            }


            //if (cmbCemInt.Text == "JARDIN" && cmbTipoConstInt.Text == "Sepultura")
            //{
            //    txtNNumNicho.Enabled = false;
            //    txtNTamNicho.Enabled = false;
            //    txtNGaleria.Enabled = false;
            //    txtNEstado.Enabled = false;
            //    txtNSeccion.Enabled = true;
            //    txtNZona.Enabled = true;
            //    txtNCuadro.Enabled = true;
            //    txtNLote.Enabled = true;
            //}
            //else
            //{
            //    txtSeccion.Enabled = false;

            //}
            //    LimpiarCampos();
        }

    }
}

