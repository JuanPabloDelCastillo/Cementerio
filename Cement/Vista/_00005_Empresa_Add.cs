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
    public partial class _00005_Empresa_Add : Form
    {

        public _00005_Empresa_Add(Empresa paramEmpresa)
        {
            InitializeComponent();

            this.objEmpresa = paramEmpresa;

        }


        Empresa objEmpresa = new Empresa();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.objEmpresa.Nombre_Emp = txtDescripcion.Text;
            int resultado = this.objEmpresa.InsertarActualizar();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
