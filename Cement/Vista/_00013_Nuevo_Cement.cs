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
    public partial class _00013_Nuevo_Cement : Form
    {
        public _00013_Nuevo_Cement(Cement_Externo ParamExterno)
        {
            InitializeComponent();
            this.objExterno = ParamExterno;
        }

        Cement_Externo objExterno = new Cement_Externo();

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.objExterno.Nombre_OtroCem = this.txtDescri.Text;
                //this.objNomencCausTrasl.Cuadro = "";
                //this.objNomencCausTrasl.Zona = "";
                //this.objNomencCausTrasl.Lote = "";
                //this.objNomencCausTrasl.ant_Codcem = "";
                //this.objNomencCausTrasl.ant_Cuadro = "";
                //this.objNomencCausTrasl.ant_Zona = "";
                //this.objNomencCausTrasl.ant_Lote = "";
                //this.objNomencCausTrasl.Seccion = "";
                //       this.objNomencCausTrasl.Fecha_Traslado. = ;
              //  this.objNomencCausTrasl.Estado = "";

                int resultado = this.objExterno.InsertarActualizar();
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

      }
    }
    
