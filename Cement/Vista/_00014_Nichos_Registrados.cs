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
    public partial class _00014_Nichos_Registrados : Form
    {
        
        public _00014_Nichos_Registrados()
        {
            InitializeComponent();
        }

        private Nicho objNicho = new Nicho();
        private Galeria objGaleria = new Galeria();

        private void _00014_Nichos_Registrados_Load(object sender, EventArgs e)
        {
            this.dgvNichos.DataSource = this.objNicho.MostrarTodos();
        }

        private void dgvNichos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dgvNichos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.Handled = false;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

     }
}
