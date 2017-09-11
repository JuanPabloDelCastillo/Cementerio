using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement
{
    public partial class _00015_Nuevo_Nicho : Form
    {
        private Nicho objNicho = new Nicho();
        private Galeria objGaleria = new Galeria();
        private TamanoNicho objTamanoNicho = new TamanoNicho();
        private EstadoNicho objEstadoNicho = new EstadoNicho();
        public _00015_Nuevo_Nicho(Nicho ParamNicho)
        {
            InitializeComponent();
            this.objNicho = ParamNicho;
            cargarEstadoNicho();
            cargarTamanoNicho();
            cargarGaleria();
        }

        public void cargarTamanoNicho()
        {
            try
            {

                this.cmbTamNicho.ValueMember = "IdTamanoNicho";
                this.cmbTamNicho.DisplayMember = "TamanoNichoT";
                this.cmbTamNicho.DataSource = new TamanoNicho().MostrarTodos();
                this.cmbTamNicho.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarGaleria()
        {
            try
            {
                this.cmbGaleria.ValueMember = "IdGaleria";
                this.cmbGaleria.DisplayMember = "GaleriaN";
                this.cmbGaleria.DataSource = new Galeria().MostrarTodos();
                this.cmbGaleria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarEstadoNicho()
        {
            try
            {
                this.cmbEstado.ValueMember = "IdEstado";
                this.cmbEstado.DisplayMember = "EstadoNichos";
                this.cmbEstado.DataSource = new EstadoNicho().MostrarTodos();
                this.cmbEstado.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.objNicho.NumeroNicho = this.txtNichoNumero.Text;
            this.objNicho.IdTamanoNicho = Convert.ToInt32(this.cmbTamNicho.SelectedValue);
            //this.objNicho.Galeria.GaleriaN = this.cmbGaleria.Text;
            this.objNicho.IdEstado = Convert.ToInt32(this.cmbEstado.SelectedValue);
            //this.objNicho.IdEstado = Convert.ToInt32(this.txtEstadoNicho.Text);
            this.objNicho.IdGaleria = Convert.ToInt32(this.cmbGaleria.SelectedValue);

            //if (!string.IsNullOrEmpty(this.txtGaleria.Text))
            //{
            //    this.objNicho.IdGaleria = Convert.ToInt32(this.txtGaleria.Text);//cuando se deja vacia la funcion convert.Toint32, no se puede convertir un vacío a numero, hay que condicionarlo.
            //}

            if (this.cmbTamNicho.SelectedValue != null)
            {
                if (!string.IsNullOrEmpty(this.cmbTamNicho.SelectedValue.ToString()))
                {
                    this.objEstadoNicho.IdEstado = Convert.ToInt32(this.cmbTamNicho.SelectedValue);

                }
            }

            if (this.cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione Un Estado", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbEstado.Focus();
                return;
            }           

            int resultado = this.objNicho.InsertarActualizar();
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNichoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void cmbEstado_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void txtNichoNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNichoNumero.Text)) //si esta vacío no hará nada.
                {
                    MessageBox.Show("El Número de Nicho no puede estar vacio");
                    e.Cancel = true;
                }
            }
            catch
            { }
        }

        private void cmbGaleria_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.cmbTamNicho.SelectedValue == null)
                {
                    MessageBox.Show("Seleccionar el Tamaño del Nicho", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbTamNicho.Focus();
                    return;

                }
            }
            catch
            { }
        }

        //private void cmbEstado_MouseClick(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        if (this.cmbGaleria.SelectedValue == null)
        //        {
        //            MessageBox.Show("Seleccione la Galeria", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            this.cmbGaleria.Focus();
        //            btnGuardar.Enabled = false;
        //            return;

        //        }
        //    }
        //    catch
        //    { }
        //}

        //private void cmbEstado_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (this.cmbEstado.SelectedValue == null)
        //        {
        //            MessageBox.Show("Seleccione Un Estado", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            btnGuardar.Enabled = false;
        //            this.cmbEstado.Focus();

        //            return;
        //        }
        //        else 
        //            btnGuardar.Enabled = true;

        //    }
        //    catch
        //    { }
        //}

        private void cmbEstado_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.cmbGaleria.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione la Galeria", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbGaleria.Focus();
                    btnGuardar.Enabled = false;
                    return;

                }
            }
            catch
            { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.objNicho.Eliminar();
                MessageBox.Show("El registro fue Eliminado exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.objNicho.MostrarTodos();
            }

            //private void cmbEstado_MouseClick(object sender, MouseEventArgs e)
            //{
            //    {
            //        try
            //        {
            //            if (this.cmbEstado.SelectedValue == null)
            //            {
            //                btnGuardar.Enabled = false;
            //                MessageBox.Show("Seleccione Un Estado", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                this.cmbEstado.Focus();
            //                return;
            //            }

            //        }
            //        catch
            //        { }
            //    }
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



