using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
  public class TamanoNicho
    {
        #region"Constructor"
        public TamanoNicho()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        {

        }
        #endregion

        #region"Propiedades"
        public int IdTamanoNicho { get; set; }
        public string TamanoNichoT { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.IdTamanoNicho = (int)objDataRow["IdTamanoNicho"];
                this.TamanoNichoT = objDataRow["TamanoNichoT"].ToString();

            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_TamanoNicho_Seleccionar", OpcionSeleccionar, this.IdTamanoNicho);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_TamanoNicho_InsertarActualizarEliminar", OpcionMantenimiento,
               this.IdTamanoNicho, this.TamanoNichoT);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.IdTamanoNicho == 0) { return null; }//valida que el id sea diferente de cero
            if (this.TamanoNichoT == null || this.TamanoNichoT == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.IdTamanoNicho, this.TamanoNichoT);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}

