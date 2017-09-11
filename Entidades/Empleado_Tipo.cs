using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Empleado_Tipo
    {
        #region"Constructor"
        public Empleado_Tipo()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public int id_Empleado_Tipo { get; set; }
        public string Funcion { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_Empleado_Tipo = (int)objDataRow["id_Empleado_Tipo"];
                this.Funcion = objDataRow["Funcion"].ToString();

            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Empleado_Tipo_Seleccionar", OpcionSeleccionar, this.id_Empleado_Tipo);
        }

        public int InsertarActualizar()
        {
            return this.EjecutarInsertarActualizarEliminar("IU");//Insertar o actualizar.
        }

        public int Eliminar()
        {
            return this.EjecutarInsertarActualizarEliminar("D");
        }

        private int EjecutarInsertarActualizarEliminar(string OpcionMantenimiento)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Empleado_Tipo_InsertarActualizarEliminar", OpcionMantenimiento,
               this.id_Empleado_Tipo, this.Funcion);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Empleado_Tipo == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Funcion == null || this.Funcion == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Empleado_Tipo, this.Funcion);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}
