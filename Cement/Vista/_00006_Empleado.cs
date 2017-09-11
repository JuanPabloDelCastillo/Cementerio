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
    public partial class _00006_Empleado : Form
    {
        USUARIOS objUSUARIOS = new USUARIOS();
        public _00006_Empleado()
        {
            InitializeComponent();
         }

        //private Empleado objEmpleado = new Empleado();
         


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _00006_Empleado_Load(object sender, EventArgs e)
        {
            //this.dgvEmpleado.DataSource = this.objEmpleado.MostrarTodos();
            this.dgvUSUARIOS.DataSource = this.objUSUARIOS.MostrarTodos();
        }


        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dgvEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.Handled = false;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
    }

