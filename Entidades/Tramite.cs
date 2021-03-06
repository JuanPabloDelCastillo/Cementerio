﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Tramite
    {
        #region"Constructor"
        public Tramite()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public int id_TipoTramite { get; set;}
        public int id_Tramite { get; set; }
        public string Tramite_Tipo { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_TipoTramite = (int)objDataRow["id_TipoTramite"];
                this.id_Tramite = (int)objDataRow["id_Tramite"];
                this.Tramite_Tipo = (string)objDataRow["Tramite_Tipo"];
                this.Estado = (bool)objDataRow["Estado"];

            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Tramite_Seleccionar", OpcionSeleccionar, this.id_TipoTramite, this.id_Tramite);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Tramite_InsertarActualizarEliminar", OpcionMantenimiento, this.id_TipoTramite, this.id_Tramite,
               this.Tramite_Tipo, this.Estado);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Tramite == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Tramite_Tipo == null || this.Tramite_Tipo == "") { return null; }//valida que la descrip no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Tramite, this.Tramite_Tipo);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}
