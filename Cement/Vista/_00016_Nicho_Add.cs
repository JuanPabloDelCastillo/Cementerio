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
    public partial class _00016_Nicho_Add : Form
    {
        Galeria objGaleria = new Galeria();
        Nicho objNicho = new Nicho();
        public _00016_Nicho_Add()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _00015_Nuevo_Nicho objForm = new _00015_Nuevo_Nicho(new Nicho());//enviar como parametro un nuevo causante
            objForm.ShowDialog();
            //            this.dgvNicho.DataSource = this.objNicho.MostrarTodos();
            PoblarGrid();
        }

        private void _00016_Nicho_Add_Load(object sender, EventArgs e)
        {
            PoblarGrid();
            //this.dgvNicho.DataSource = this.objNicho.MostrarTodos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PoblarGrid()
        {

            List<Nicho> objNicho = new List<Nicho>();

            this.dgvNicho.DataSource = this.objNicho.MostrarTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {           
            if (this.dgvNicho.RowCount > 0)

                //en este caso ya no mandaremos un nuevo Empleado ya que vamos a modificar.
                this.objNicho.NumeroNicho = (this.dgvNicho.CurrentRow.Cells["ColumnNumeroNicho"].Value.ToString());//asignando el id que voy a buscar
            this.objNicho.Seleccionar();//buscando por id(clave primaria)
            try
            {
                if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.objNicho.Eliminar();
                    MessageBox.Show("El registro fue Eliminado exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    //this.dgvNicho.RefreshEdit();

                    this.dgvNicho.Refresh();
                    this.objNicho.MostrarTodos();
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

        
    
