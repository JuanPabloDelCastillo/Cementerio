using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoNicho
    {
        #region"Constructor"
        public EstadoNicho()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        {

        }
        #endregion

        #region"Propiedades"
        public int IdEstado { get; set; }
        public string EstadoNichos { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.IdEstado = (int)objDataRow["IdEstado"];
                this.EstadoNichos = objDataRow["EstadoNichos"].ToString();

            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_EstadoNicho_Seleccionar", OpcionSeleccionar, this.IdEstado);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_EstadoNicho_InsertarActualizarEliminar", OpcionMantenimiento,
               this.IdEstado, this.EstadoNichos);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.IdEstado == 0) { return null; }//valida que el id sea diferente de cero
            if (this.EstadoNichos == null || this.EstadoNichos == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.IdEstado, this.EstadoNichos);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}
