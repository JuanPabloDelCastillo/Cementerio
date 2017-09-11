using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Historico
    {
        #region"Constructor"
        public Historico()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        {

        }
        #endregion

        #region"Propiedades"
        public int id_Nomenc { get; set; }
        public string Dni { get; set; }
        public string Codcem { get; set; }
        public string Cuadro { get; set; }
        public string Zona { get; set; }
        public string Lote { get; set; }
        public string Seccion { get; set; }
        public Boolean Estado { get; set; }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            try
            {
                DataTable objDataTable = this.EjecutarConsulta("S");
                foreach (DataRow objDataRow in objDataTable.Rows)
                {
                    this.id_Nomenc = (int)objDataRow["id_Nomenc"];
                    this.Dni = objDataRow["Dni"].ToString();
                    this.Codcem = objDataRow["Codcem"].ToString();
                    this.Cuadro = objDataRow["Cuadro"].ToString();
                    this.Zona = objDataRow["Zona"].ToString();
                    this.Lote = objDataRow["Lote"].ToString();
                    this.Seccion = objDataRow["Seccion"].ToString();
                    this.Estado = (Boolean)objDataRow["Estado"];
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Historico_Seleccionar", OpcionSeleccionar, this.id_Nomenc, this.Dni);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Historico_InsertarActualizarEliminar", OpcionMantenimiento,
                this.id_Nomenc, this.Dni, this.Codcem, this.Cuadro, this.Zona, this.Lote, this.Seccion, this.Estado);
            //this.N_Codcem, this.N_Cuadro, this.N_Zona, this.N_Lote, this.N_Seccion,
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Nomenc == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Codcem == null || this.Codcem == "") { return null; }//valida que el codcem no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Nomenc, this.Codcem);//returna un valor de tipo texto con el id y el codcem, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}
