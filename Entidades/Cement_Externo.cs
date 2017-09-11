using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccesoDatos;

namespace Entidades
{
   public class Cement_Externo
    {
        #region"Constructor"
        public Cement_Externo()
            : base()
        {
        }
        #endregion

        #region"Propiedades"
        public int id_OtroCem { get; set; }
        public string Nombre_OtroCem { get; set; }
        #endregion



        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_OtroCem = (int)objDataRow["id_OtroCem"];
                this.Nombre_OtroCem = objDataRow["Nombre_OtroCem"].ToString();

            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Cement_Externo_Seleccionar", OpcionSeleccionar, this.id_OtroCem);
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
                                                                                     
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Cement_Externo_InsertarActualizarEliminar", OpcionMantenimiento,
                this.id_OtroCem, this.Nombre_OtroCem);
        }
        #endregion

        #region"Metodos sobreescritos"
        public override string ToString()
        {
            if (this.id_OtroCem == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Nombre_OtroCem == null || this.Nombre_OtroCem == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_OtroCem, this.Nombre_OtroCem);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}

