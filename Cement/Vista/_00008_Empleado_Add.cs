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
    public partial class _00008_Empleado_Add : Form
    {
        public _00008_Empleado_Add()
        {
            InitializeComponent();
        }

        public Empleado objEmpleado = new Empleado();

        private void _00008_Empleado_Add_Load(object sender, EventArgs e)
        {
            this.dgvEmpleados.DataSource = this.objEmpleado.MostrarTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //para enviar un nuevo Empleado como parametro tenemos 2 opciones:
            //1- crear una variable de tipo causante y enviarlo de la siguiente manera: 
            //Causante objCausante = new Causante();
            //_00007_EmpleadoN objForm = new _00007_EmpleadoN(objEmpleado);
            //2- enviarlo del modo directo sin crear variable para no ocupar espacios de memoria.
            _00007_EmpleadoN objForm = new _00007_EmpleadoN(new Empleado());
            objForm.Text = "Nuevo Empleado";
            objForm.btnEliminar.Enabled = false;
            objForm.ShowDialog();
            this.dgvEmpleados.DataSource = this.objEmpleado.MostrarTodos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //en este caso ya no mandaremos un nuevo Empleado ya que vamos a modificar.
            this.objEmpleado.Dni = (this.dgvEmpleados.CurrentRow.Cells["ColumnDni"].Value.ToString());//asignando el id que voy a buscar
            this.objEmpleado.Seleccionar();//buscando por id (clave primaria)
            if (!string.IsNullOrEmpty(this.objEmpleado.ToString()))
            {
                _00007_EmpleadoN objForm = new _00007_EmpleadoN(this.objEmpleado);//enviar como parametro un nuevo causante
                objForm.Text = "Modificar Empleado";
                objForm.btnEliminar.Enabled = false;
                objForm.btnGuardar.Enabled = true;
                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvEmpleados.DataSource = this.objEmpleado.MostrarTodos();
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente DNI: " + this.objEmpleado.id_Empleado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // if (this.dgvEmpleados.RowCount == 0) { return; }

            //en este caso ya no mandaremos un nuevo Empleado ya que vamos a modificar.
            this.objEmpleado.Dni = (this.dgvEmpleados.CurrentRow.Cells["ColumnDni"].Value.ToString());//asignando el id que voy a buscar
            this.objEmpleado.Seleccionar();//buscando por id(clave primaria)

            //if (MessageBox.Show("Estas seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    this.objEmpleado.Eliminar();
            //    MessageBox.Show("El registro fue Eliminado exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //    this.objEmpleado.MostrarTodos();
            //}
            // return;

            if (!string.IsNullOrEmpty(this.objEmpleado.ToString()))
            {
                _00007_EmpleadoN objForm = new _00007_EmpleadoN(this.objEmpleado);//enviar como parametro un nuevo causante

                objForm.txtNombre.ReadOnly = true;
                objForm.txtDni.ReadOnly = true;
                objForm.txtCuil.ReadOnly = true;
                objForm.txtAfiliado_Num.ReadOnly = true;
                objForm.cmbFuncion.Enabled = false;
                objForm.btnFuncion.Enabled = false;
                objForm.txtCalle.ReadOnly = true;
                objForm.txtCalle_Num.ReadOnly = true;
                objForm.txtPiso.ReadOnly = true;
                objForm.txtDepartamento.ReadOnly = true;
                objForm.txtTelefono.ReadOnly = true;
                objForm.txtCelular.ReadOnly = true;
                objForm.txtEmail.ReadOnly = true;
                objForm.txtTurno.ReadOnly = true;
                objForm.cmbFechaIngreso.Enabled = false;
                objForm.imgFotoEmp.Enabled = false;
                objForm.btnGuardar.Enabled = false;


                objForm.ShowDialog();
                //aqui puedo cargar el datagrid, solo tengo que aplicar la misma linea de código en el evento load.
                this.dgvEmpleados.DataSource = this.objEmpleado.MostrarTodos();
            }
            else { MessageBox.Show("Atención!!!", "No existe registro con el siguiente id: " + this.objEmpleado.id_Empleado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
}
        }

  
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = this.dgvEmpleados.DataSource;
                objBindingSource.Filter = "Nombre_E LIKE '%" + this.txtBusqueda.Text + "%'";
                this.dgvEmpleados.DataSource = objBindingSource.DataSource;
            }
            catch { }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
