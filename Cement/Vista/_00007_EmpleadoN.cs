using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Cement.Vista;
using Cement.Properties;
using System.Drawing.Imaging;
using Entidades;
using System.Text.RegularExpressions;

namespace Cement.Vista
{
    public partial class _00007_EmpleadoN : Form
    {
        private Empleado objEmpleado = new Empleado();

      
        

        public _00007_EmpleadoN(Empleado ParamEmpleado)
        {
            InitializeComponent();
            this.objEmpleado = ParamEmpleado;
            cargarFuncion();

            if (!string.IsNullOrEmpty(this.objEmpleado.ToString()))
            {
                this.txtNombre.Text = this.objEmpleado.Nombre_E;
                this.txtCalle.Text = this.objEmpleado.Calle;
                this.txtCalle_Num.Text = this.objEmpleado.Calle_Numero;
                this.txtPiso.Text = this.objEmpleado.Piso;
                this.txtDepartamento.Text = this.objEmpleado.Departamento;
                this.txtTelefono.Text = this.objEmpleado.Telefono;
                this.txtCelular.Text = this.objEmpleado.Celular;
                this.txtEmail.Text = this.objEmpleado.Email;
                this.cmbFechaIngreso.Value = this.objEmpleado.Fecha_Ingreso;
                this.txtDni.Text = this.objEmpleado.Dni;
                this.txtCuil.Text = this.objEmpleado.Cuil;
                this.txtAfiliado_Num.Text = this.objEmpleado.Afiliado_Num;
                this.cmbFuncion.SelectedValue = this.objEmpleado.id_Empleado_Tipo;
                this.txtTurno.Text = this.objEmpleado.Turno;

                if (this.objEmpleado.Foto != null)
                {
                    byte[] Imagen = this.objEmpleado.Foto;
                    MemoryStream objMemoryStream = new MemoryStream(Imagen);
                    this.imgFotoEmp.Image = Image.FromStream(objMemoryStream);
                }
                else { this.imgFotoEmp.Image = null; }
            }

            }
        

        public void cargarFuncion()
        {
            try
            {
                this.cmbFuncion.ValueMember = "id_Empleado_Tipo";
                this.cmbFuncion.DisplayMember = "Funcion";
                this.cmbFuncion.DataSource = new Empleado_Tipo().MostrarTodos();
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
                this.objEmpleado.Nombre_E = this.txtNombre.Text;
                this.objEmpleado.Calle = this.txtCalle.Text;
                this.objEmpleado.Calle_Numero = this.txtCalle_Num.Text;
                this.objEmpleado.Piso = this.txtPiso.Text;
                this.objEmpleado.Departamento = this.txtDepartamento.Text;
                this.objEmpleado.Telefono = this.txtTelefono.Text;
                this.objEmpleado.Celular = this.txtCelular.Text;
                this.objEmpleado.Email = this.txtEmail.Text;
                this.objEmpleado.Fecha_Ingreso = this.cmbFechaIngreso.Value;
                this.objEmpleado.Dni = this.txtDni.Text;
                this.objEmpleado.Cuil = this.txtCuil.Text;
                this.objEmpleado.Afiliado_Num = this.txtAfiliado_Num.Text;
                this.objEmpleado.id_Empleado_Tipo = Convert.ToInt32(this.cmbFuncion.SelectedValue);
  
                ///GUARDAMOS LA FOTO EN UNA VARIABLE DE MEMORIA
                MemoryStream objMemoryStream = new MemoryStream();
                if (this.imgFotoEmp.Image != null)
                {
                    this.imgFotoEmp.Image.Save(objMemoryStream, ImageFormat.Png);
                    this.objEmpleado.Foto = objMemoryStream.GetBuffer();
                }
                else { this.objEmpleado.Foto = null; }
                ///////////////////////

                this.objEmpleado.Turno = this.txtTurno.Text;
               // this.objEmpleado.id_Empleado_Tipo = 0;
                //this.objEmpleado.id_Usuario = 0;


                int resultado = this.objEmpleado.InsertarActualizar();
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
                    MessageBox.Show("No es posible guardar el Equipo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

    
        //EVENTO PARA CARGAR FOTO

        private void imgFotoEmp_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objopenFileDialog = new OpenFileDialog();

                objopenFileDialog.Filter = "Imágenes png|*.png";

                if (objopenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.imgFotoEmp.Load(objopenFileDialog.FileName);
                }
                else
                {
                    this.imgFotoEmp.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        //

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
            
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            _00009_Funcion_Add NewTipo = new _00009_Funcion_Add(new Empleado_Tipo());

            NewTipo.ShowDialog();

            cargarFuncion();
        }

        private void _00007_EmpleadoN_Load(object sender, EventArgs e)
        {
            cargarFuncion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.objEmpleado.Eliminar();
                MessageBox.Show("El registro fue Eliminado exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.objEmpleado.MostrarTodos();
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtAfiliado_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void txtCalle_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }//si son controles como el suprimir y borrar, no hace nada.
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (!char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es diferente de numero los evita.
            e.Handled = false;
        }

        private void txtTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text)) //si esta vacío no hará nada.
            {
                MessageBox.Show("El Nombre no puede estar vacío");
                txtNombre.Focus();
                return;
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("El Dni no puede estar vacío.");
                txtDni.Focus();
                return; 
            }
                if (!string.IsNullOrEmpty(this.objEmpleado.ToString())) { return; }
                Empleado objEmpleadoDNI = new Empleado();
                objEmpleadoDNI.Dni = txtDni.Text;
                objEmpleadoDNI.Seleccionar();
                if (!string.IsNullOrEmpty(objEmpleadoDNI.ToString()))
                {
                    MessageBox.Show("El Dni ingresado ya existe..cámbielo!!");
                    e.Cancel = true;
                }
            }
        

        private void txtAfiliado_Num_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAfiliado_Num.Text))
            {
                MessageBox.Show("El Afiliado no puede estar vacío");
                txtAfiliado_Num.Focus();
                return;
            }
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCalle.Text)) //si esta vacío no hará nada.
            {
                MessageBox.Show("La Calle no puede estar vacía");
                txtCalle.Focus();
                return;
            }
        }

        private void txtCalle_Num_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCalle_Num.Text))
            {
                MessageBox.Show("El Numero no puede estar vacío");
                txtCalle_Num.Focus();
                return;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCuil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbFuncion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCalle_Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPiso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbFechaIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        public static bool validarEmail(string Email)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txtEmail.Text))
            {

            }
            else
            {
              MessageBox.Show("Dirección de Correo no valida, el correo debe tener el formato (Ej.): nombre@dominio.com", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              txtEmail.SelectAll();
              txtEmail.Focus();
            }
        }   
    }
}

