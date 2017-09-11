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
    public partial class _00003_Cement_Tipo : Form
    {

        public _00003_Cement_Tipo(Nomenc ParamNomenc)
        {
            InitializeComponent();
            this.objNomenc = ParamNomenc;
        }

        Nomenc objNomenc = new Nomenc();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
            this.objNomenc.Codcem = this.txtDescripcion.Text;

            this.objNomenc.Cuadro = "";
            this.objNomenc.Zona = "";
            this.objNomenc.Lote = "";
            //this.objNomenc.N_Codcem = "";
            //this.objNomenc.N_Cuadro = "";
            //this.objNomenc.N_Zona = "";
            //this.objNomenc.N_Lote = "";
            //this.objNomenc.Seccion = "";

            int resultado = this.objNomenc.InsertarActualizar();
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
            
            //this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
