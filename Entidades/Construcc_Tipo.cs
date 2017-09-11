using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Construcc_Tipo
    {
        #region"Constructor"
        public Construcc_Tipo()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public int id_Nomenc { get; set; }
        public int id_Construccion { get; set; }
        public string Nombre_C { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_Nomenc = (int)objDataRow["id_Nomenc"];
                this.id_Construccion = (int)objDataRow["id_Construccion"];
                this.Nombre_C = (string)objDataRow["Nombre_C"];
                this.Estado = (bool)objDataRow["Estado"];
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Construcc_Tipo_Seleccionar", OpcionSeleccionar, this.id_Nomenc, this.id_Construccion);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Construcc_Tipo_InsertarActualizarEliminar", OpcionMantenimiento, this.id_Nomenc, this.id_Construccion, this.Nombre_C, this.Estado);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Construccion == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Nombre_C == null || this.Nombre_C == "") { return null; }//valida que la descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Construccion, this.Nombre_C);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }


        #endregion
    }
}
