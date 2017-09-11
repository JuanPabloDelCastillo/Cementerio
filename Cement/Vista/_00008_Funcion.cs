using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Cement.Controlador;
using Cement.Modelo;
using System.Windows.Forms;

namespace Cement.Vista
{
    public partial class _00008_Funcion : Form
    {
        public _00008_Funcion()
        {
            InitializeComponent();
        }



        public DataTable tablaFuncion(List<Empleado_Tipo> listEmpleadoTipo)
        {
            //Creamos una Tabla virtual para manejar los datos que queremos mostrar
            DataTable tableFuncion = new DataTable();

            try
            {


                tableFuncion.Columns.Add(new DataColumn("id_Empleado_Tipo", Type.GetType("System.Int32")));
                tableFuncion.Columns.Add(new DataColumn("Funcion", Type.GetType("System.String")));

                foreach (Empleado_Tipo EmpleadoTipo in listEmpleadoTipo)
                {
                    tableFuncion.Rows.Add(
                        EmpleadoTipo.id_Empleado_Tipo,
                        EmpleadoTipo.Funcion

                        );
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableFuncion; //AQUI LA CARGAMOS PARA QUE SE ACTUALICE DIRECTAMENTE DESDE LA BASE DE DATOS
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cement.Vista._00009_Funcion_Add NewTipo = new _00009_Funcion_Add();
            NewTipo.FormClosed += new System.Windows.Forms.FormClosedEventHandler(NewTipo_FormClosed);

            NewTipo.ShowDialog();
        }

        private void NewTipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PoblarGrid();
        }

        public void PoblarGrid()
        {

            List<Empleado_Tipo> listEmpleado_Tipo = new CementEntity().Empleado_Tipo.ToList();

            this.dgvFuncion.DataSource = this.tablaFuncion(listEmpleado_Tipo);

        }

    }
}
