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
    public partial class _00009_Funcion_Add : Form
    {

        public _00009_Funcion_Add(Empleado_Tipo paramEmpleado_Tipo)
        {
            InitializeComponent();

            this.objFuncion = paramEmpleado_Tipo;
        }


        Empleado_Tipo objFuncion = new Empleado_Tipo();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.objFuncion.Funcion = this.txtDescripcionF.Text;




                int resultado = this.objFuncion.InsertarActualizar();
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
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
