using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Empresa
    {
        #region"Constructor"
        public Empresa()
            : base()
        {
        }
        #endregion

        #region"Propiedades"
        public int id_Empresa { get; set; }
        public string Nombre_Emp { get; set; }
        #endregion

        

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_Empresa = (int)objDataRow["id_Empresa"];
                this.Nombre_Emp = objDataRow["Nombre_Emp"].ToString();
                
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Empresa_Seleccionar", OpcionSeleccionar, this.id_Empresa);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Empresa_InsertarActualizarEliminar", OpcionMantenimiento,
                this.id_Empresa, this.Nombre_Emp);
        }
        #endregion

        #region"Metodos sobreescritos"
        public override string ToString()
        {
            if (this.id_Empresa == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Nombre_Emp == null || this.Nombre_Emp == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Empresa, this.Nombre_Emp);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }

 
}
