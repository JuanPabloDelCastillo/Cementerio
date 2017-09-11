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
    public partial class Usuarios_Add : Form
    {
        public Usuarios_Add()
        {
            InitializeComponent();
        }

        Encriptamiento encri = new Encriptamiento();

        public void limpiar()
        {
            txtnombre.Text = "";
            txtclave.Text = "";
            cbotipo.Text = "SELECCIONE TIPO";
        }

        private void Usuarios_Add_Load(object sender, EventArgs e)
        {

        }

  
        private static Usuarios_Add m_FormDefInstance;
        public static Usuarios_Add DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Usuarios_Add();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btngrabar_Click_1(object sender, EventArgs e)
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
            if (this.cbotipo.Text == "SELECCIONE TIPO")
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbotipo.Select();
                return;
            }

            try
            {
                var nom = txtnombre.Text.Trim();
                var cla = txtclave.Text.Trim();
                var tip = cbotipo.Text.Trim();

                var aux = new Service(0, nom, encri.EncryptKey(cla), tip);

                if (Service.Agregar(aux)) //si la funcion agregar pudo insertar
                {
                    MessageBox.Show("Usuario Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else//si no pudo insertar
                {
                    MessageBox.Show("Usuario No Fue Registrado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }

        private void cbotipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

