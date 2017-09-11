using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cement.Vista;


namespace Cement.Vista
{
    public partial class Login : Form
    {

        Encriptamiento encri = new Encriptamiento();
        //int a = 0;
        int veces = 0;
        private const int intentos = 2;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.comboBox111.Text == "SELECCIONAR")
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Acceso ace = new Acceso();
            ace.Usuario = txtUsuario.Text;
            ace.Clave = encri.EncryptKey(txtPassword.Text);
            ace.Tipo = comboBox111.Text;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Digite Usuario para Continuar", "Dirección de Cementerios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Digite Clave para Continuar", "Dirección de Cementerios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else if (ace.Verificar() == true)
            {
                if (comboBox111.Text == "OESTE")
                {
                    Principal inicia = new Principal();
                    inicia.Show();
                    this.Hide();
                    inicia.toolStripStatusLabel22.Text = "Usuario:  "   + txtUsuario.Text + "  -  "  + " Cargo:   "  + comboBox111.Text.ToString();
                    inicia.menuToolStripMenuItem.Enabled = false;
                    inicia.norteToolStripMenuItem.Enabled = false;
                    inicia.jardinToolStripMenuItem.Enabled = false;

                }

                else
                {
                    Principal inicia = new Principal();
                    inicia.Show();
                    this.Hide();
                    inicia.toolStripStatusLabel22.Text = "Usuario:  "   + txtUsuario.Text + "  -  "  + " Cargo:   "  + comboBox111.Text.ToString();
                    inicia.menuToolStripMenuItem.Enabled = true;                    
                }

                if (comboBox111.Text == "NORTE")
                {
                    Principal inicia = new Principal();
                    inicia.Show();
                    this.Hide();
                    inicia.toolStripStatusLabel22.Text = "Usuario:  " + txtUsuario.Text + "  -  " + " Cargo:   " + comboBox111.Text.ToString();
                    inicia.menuToolStripMenuItem.Enabled = false;
                    inicia.oesteToolStripMenuItem.Enabled = false;
                    inicia.jardinToolStripMenuItem.Enabled = false;
                }

                if (comboBox111.Text == "JARDIN")
                {
                    Principal inicia = new Principal();
                    inicia.Show();
                    this.Hide();
                    inicia.toolStripStatusLabel22.Text = "Usuario:  " + txtUsuario.Text + "  -  " + " Cargo:   " + comboBox111.Text.ToString();
                    inicia.menuToolStripMenuItem.Enabled = false;
                    inicia.oesteToolStripMenuItem.Enabled = false;
                    inicia.norteToolStripMenuItem.Enabled = false;
                }

                if (comboBox111.Text == "CONSULTAS")
                {
                    Principal inicia = new Principal();
                    inicia.Show();
                    this.Hide();
                    inicia.toolStripStatusLabel22.Text = "Usuario:  " + txtUsuario.Text + "  -  " + " Cargo:   " + comboBox111.Text.ToString();
                    inicia.menuToolStripMenuItem.Enabled = false;
                    //inicia.empleadosToolStripMenuItem.Enabled = false;
                    inicia.oesteToolStripMenuItem.Enabled = false;
                    inicia.norteToolStripMenuItem.Enabled = false;
                    inicia.jardinToolStripMenuItem.Enabled = false;
                }

            }
            else
            {
                if (veces == 2)
                {
                    MessageBox.Show(ace.Mensaje, "Cementerio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Su Usuario, Contraseña o Tipo no coinciden o son erróneos \n \n                        Le Quedan " + (intentos - veces) +" Intento(s)", "       Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    veces = veces + 1;
                }
            }
            //string conexion = "Data Source=.\\SQLEXP;Initial Catalog=usuario; contraseña;Integrated Security=True";
            /*creamos un objeto sqlconnection*/
            //SqlConnection cn = new SqlConnection(@"server =.\SQLEXP; user = sa; password = sql; database = Cementerio;");
            /*cramos un objeto sqlcommand*/
            //SqlCommand comando = new SqlCommand("select count(*)from Usuario where Usuario=@user and Password=@contra", cn);
            /*Le pasamos los parametros, a la tabla T_acceso y sus campos*/
            //comando.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsuario.Text;
            //comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = txtPassword.Text;
            ///*abrimos la conexion*/
            //cn.Open();
            //int i = (int)comando.ExecuteScalar();
            //if (i > 0)
            //{
            //    MessageBox.Show("Usuario y contraseña encontrado");
            //    Principal fm = new Principal();
            //    fm.Show();
            //    this.Hide();
            //}
            //else
            //    if (a != 2)                
            //{                
            //    a = a + 1;
            //    MessageBox.Show("Error en Usuario o Contraseña", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPassword.Clear();
            //    txtUsuario.Focus();
            //}

            //else
            //{
            //    MessageBox.Show("Ya se produjeron tres Intentos erróneos...Saliendo..", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.DialogResult = DialogResult.OK;
            //    cn.Close();
            //    this.Close();
            //}
        }

        private void comboBox111_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) { e.Handled = true; return; }//evita los puntos y comas, ect...
            if (char.IsSymbol(e.KeyChar)) { e.Handled = true; return; }//evita los symbolos
            if (char.IsNumber(e.KeyChar)) { e.Handled = true; return; }//si es numero los evita.
            e.Handled = false;
        }
    }
}
