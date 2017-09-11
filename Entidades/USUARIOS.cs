using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class USUARIOS
    {

        #region"Constructor"
        public USUARIOS()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        {

        }
        #endregion

        #region"Propiedades"
        public int CODIGO { get; set; }
        public string NOMBREU { get; set; }
        public string CLAVE { get; set; }
        public string TIPO { get; set; }

        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.CODIGO = (int)objDataRow["CODIGO"];
                this.NOMBREU = objDataRow["NOMBREU"].ToString();
                this.CLAVE = objDataRow["CLAVE"].ToString();
                this.TIPO = objDataRow["TIPO"].ToString();
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_USUARIOS_Seleccionar", OpcionSeleccionar, this.CODIGO);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_USUARIOS_InsertarActualizarEliminar", OpcionMantenimiento,
               this.CODIGO, this.NOMBREU, this.CLAVE, this.TIPO);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.CODIGO == 0) { return null; }//valida que el id sea diferente de cero
            if (this.NOMBREU == null || this.NOMBREU == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("CODIGO: {0} NOMBREU: {1}", this.NOMBREU, this.NOMBREU);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}
