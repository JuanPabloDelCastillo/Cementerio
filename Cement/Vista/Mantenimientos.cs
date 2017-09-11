using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cement.Clases;

namespace Cement.Vista
{
    public partial class Mantenimientos : Form
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        Encriptar_Desencriptar encri = new Encriptar_Desencriptar();

        private void Activaciones()
        {
            this.txtnombre.Select();
            this.txtcodigo.Text = "";
            this.txtnombre.Text = "";
            this.txtclave.Text = "";
            //this.txttipo.Text = "";
            this.txtclave2.Text = "";
            this.txtclave3.Text = "";

            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
            btnnuevo.Enabled = false;

            var aux = new Service();
            aux.listar(datausuarios);
            datausuarios.AllowUserToAddRows = false;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (this.txtnombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtnombre.Select();
                return;
            }
            if (this.txtclave.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Clave", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtclave.Select();
                return;
            }

            try
            {
                var nom = txtnombre.Text.Trim();
                var cla = txtclave.Text.Trim();
                var tip = txttipo.Text.Trim();
                var aux = new Service(0, nom, encri.EncryptKey(cla));

                if (Service.Agregar(aux)) //si la funcion agregar pudo insertar
                {
                    MessageBox.Show("Usuarios Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Activaciones();
                }
                else//si no pudo insertar
                {
                    MessageBox.Show("Usuario No Fue Resgistrado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (this.txtnombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el nombre del Usaurio a Modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtnombre.Select();
                return;
            }

            try
            {
                var nom = txtnombre.Text.Trim();
                var cla = txtclave.Text.Trim();
                var tip = txttipo.Text.Trim();
                var cod = int.Parse(txtcodigo.Text.Trim());//necesita el code para actualizar por que no sabe a quien actualizara
                var aux = new Service(cod, nom, encri.EncryptKey(cla), tip);

                if (Service.Modificar(aux))
                {
                    MessageBox.Show("Usuario Modificado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Activaciones();
                }
                else
                {
                    MessageBox.Show("Usuario No Fue Modificado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void datausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datausuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnnuevo.Enabled = true;
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                datausuarios.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                return;
            }

            if (e.ColumnIndex == 0) //Si es la columna donde esta el Eliminar
            {
                //variable que va ha capturar la respuesta del dialog resul
                DialogResult result = MessageBox.Show("Esta Seguro Que Desea Eliminar A La Persona De Nombre: " + datausuarios.CurrentRow.Cells["NOMBREU"].Value.ToString(), "Confirmation", MessageBoxButtons.OKCancel);


                if (result == DialogResult.OK) //si presiona ok Elimina
                {
                    var nom = datausuarios.CurrentRow.Cells["NOMBREU"].Value.ToString();
                    int cod = int.Parse(datausuarios.CurrentRow.Cells["CODIGO"].Value.ToString());
                    var cla = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
                    var tip = datausuarios.CurrentRow.Cells["TIPO"].Value.ToString();


                    var aux = new Service(cod, nom, cla, tip);

                    if (Service.Eliminar(aux))
                    {
                        MessageBox.Show("Eliminado Correctamente");
                        Activaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar");
                    }
                }
                else
                {
                    //si necesitamos hacer algo si la respuesta es cancelar
                }
            }
            else //Si es el resto de las Columnas
            {
                txtcodigo.Text = datausuarios.CurrentRow.Cells["CODIGO"].Value.ToString();
                txtnombre.Text = datausuarios.CurrentRow.Cells["NOMBREU"].Value.ToString();
                txtclave.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
                txtclave2.Text = datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString();
                txttipo.Text = datausuarios.CurrentRow.Cells["TIPO"].Value.ToString();
                txtclave3.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
                this.txtnombre.Select();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtcodigo.Text.Trim().Length > 0)
            {
                this.btnguardar.Enabled = false;
                this.btnmodificar.Enabled = true;
            }
            else
            {
                this.btnguardar.Enabled = true;
                this.btnmodificar.Enabled = false;
            }
        }

        private void datausuarios_KeyDown(object sender, KeyEventArgs e)
        {
            txtcodigo.Text = datausuarios.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre.Text = datausuarios.CurrentRow.Cells["NOMBREU"].Value.ToString();
            txtclave.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
            txtclave2.Text = datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString();
            txttipo.Text = datausuarios.CurrentRow.Cells["TIPO"].Value.ToString();
            txtclave3.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
        }

        private void datausuarios_MouseClick(object sender, MouseEventArgs e)
        {
            txtcodigo.Text = datausuarios.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre.Text = datausuarios.CurrentRow.Cells["NOMBREU"].Value.ToString();
            txtclave.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
            txtclave2.Text = datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString();
            txttipo.Text = datausuarios.CurrentRow.Cells["TIPO"].Value.ToString();
            txtclave3.Text = encri.DecryptKey(datausuarios.CurrentRow.Cells["CLAVE"].Value.ToString());
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            txtnombre.BackColor = Color.White;
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            txtnombre.BackColor = Color.White;
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            txtclave.BackColor = Color.White;
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            txtclave.BackColor = Color.White;
        }

        private void txtclave_KeyUp(object sender, KeyEventArgs e)
        {
            txtclave3.Text = txtclave.Text;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Activaciones();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            Activaciones();
        }
    }
}
