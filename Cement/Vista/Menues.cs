using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cement.Vista;

namespace Cement
{
    public partial class Menues : Form
    {
        public Menues()
        {
            InitializeComponent();
        }


        private void cAMBIARUSUARIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Login frm = new Login();
            //frm.Show();
            //this.Hide();
        }

        private void aGREGARUSUARIOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuarios_Add.DefInstance.MdiParent = this.MdiParent;
            Usuarios_Add.DefInstance.Show();
            //Lista.DefInstance.Close();
            //Confidencial.DefInstance.Close();
            Acerca.DefInstance.Close();
        }

        private void lISTARUSUARIOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Lista.DefInstance.MdiParent = this.MdiParent;
            //Lista.DefInstance.Show();
            Usuarios_Add.DefInstance.Close();
            //Confidencial.DefInstance.Close();
            Acerca.DefInstance.Close();
        }

        private void cONDIFENCIALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Confidencial.DefInstance.MdiParent = this.MdiParent;
            //Confidencial.DefInstance.Show();
            //Usuarios_Add.DefInstance.Close();
            //Lista.DefInstance.Close();
            //Acerca.DefInstance.Close();
            new Mantenimientos().ShowDialog();
        }

        private void aCERCADEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Acerca.DefInstance.MdiParent = this.MdiParent;
            Acerca.DefInstance.Show();
            Usuarios_Add.DefInstance.Close();
            //Lista.DefInstance.Close();
            //Confidencial.DefInstance.Close();
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Esta seguro que desea apagar el Sistema?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();

            }
        }
    }
}

