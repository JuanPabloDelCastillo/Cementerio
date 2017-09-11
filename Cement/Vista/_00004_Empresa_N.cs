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
    public partial class _00004_Empresa_N : Form
    {
       
        public _00004_Empresa_N()
        {
            InitializeComponent();
        }

        
        private Empresa objEmpresa = new Empresa();

        private void _00004_Empresa_N_Load(object sender, EventArgs e)
        {
 
            this.dgvEmpresa.DataSource = this.objEmpresa.MostrarTodos();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            _00005_Empresa_Add objForm = new _00005_Empresa_Add(new Empresa());//enviar como parametro un nuevo causante
            objForm.ShowDialog();
            this.dgvEmpresa.DataSource = this.objEmpresa.MostrarTodos();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PoblarGrid()
        {

            List<Empresa> objEmpresa = new List<Empresa>();

            this.dgvEmpresa.DataSource = this.objEmpresa.MostrarTodos();
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvEmpresa.RowCount > 0)

                //en este caso ya no mandaremos un nuevo Empleado ya que vamos a modificar.
                this.objEmpresa.id_Empresa = Convert.ToInt32(this.dgvEmpresa.CurrentRow.Cells["Columnid_Empresa"].Value.ToString());//asignando el id que voy a buscar
            this.objEmpresa.Seleccionar();//buscando por id(clave primaria)
            try
            {
                if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.objEmpresa.Eliminar();
                    MessageBox.Show("El registro fue Eliminado exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    //this.dgvNicho.RefreshEdit();

                    this.dgvEmpresa.Refresh();
                    this.objEmpresa.MostrarTodos();
                }
            }
            catch (Exception Ep)
            {
                MessageBox.Show(Ep.Message);
            }

            finally
            {
                PoblarGrid();
            }
        }


    }
}
    

