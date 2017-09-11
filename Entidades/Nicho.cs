using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Nicho
    {
         #region"Constructor"
        public Nicho()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public int id_Nicho { get; set; }
        public string NumeroNicho { get; set; }
        public string N_NumeroNicho { get; set; }
        public int IdTamanoNicho { get; set; }
        public int IdGaleria { get; set; }
        public int IdEstado { get; set; }
  
        #endregion


        #region"Relacion entre clases"
        private Galeria _Galeria;//Variable de tipo Nicho que capturara el resultado de la busqueda en la base de datos
        public Galeria Galeria//Propiedad de tipo Nicho que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.IdGaleria != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Galeria objGaleria = new Galeria();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objGaleria.IdGaleria = this.IdGaleria;//le asigno el id que es diferente de 0
                    objGaleria.Seleccionar();//aplico la busqueda en la base de datos
                    this._Galeria = objGaleria;//asigno el resultado a la variable interna
                }
                return this._Galeria;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private TamanoNicho _TamanoNicho;//Variable de tipo Nicho que capturara el resultado de la busqueda en la base de datos
        public TamanoNicho TamanoNicho//Propiedad de tipo Nicho que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.IdTamanoNicho != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    TamanoNicho objTamNicho = new TamanoNicho();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objTamNicho.IdTamanoNicho = this.IdTamanoNicho;//le asigno el id que es diferente de 0
                    objTamNicho.Seleccionar();//aplico la busqueda en la base de datos
                    this._TamanoNicho = objTamNicho;//asigno el resultado a la variable interna
                }
                return this._TamanoNicho;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private EstadoNicho _EstadoNicho;//Variable de tipo Nicho que capturara el resultado de la busqueda en la base de datos
        public EstadoNicho EstadoNicho//Propiedad de tipo Nicho que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.IdEstado != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    EstadoNicho objEstadoNicho = new EstadoNicho();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objEstadoNicho.IdEstado = this.IdEstado;//le asigno el id que es diferente de 0
                    objEstadoNicho.Seleccionar();//aplico la busqueda en la base de datos
                    this._EstadoNicho = objEstadoNicho;//asigno el resultado a la variable interna
                }
                return this._EstadoNicho;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }
        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_Nicho = (int)objDataRow["id_Nicho"];
                this.NumeroNicho = objDataRow["NumeroNicho"].ToString();
                this.N_NumeroNicho = objDataRow["N_NumeroNicho"].ToString();
                this.IdTamanoNicho = (int)objDataRow["IdTamanoNicho"];
                this.IdGaleria = (int)objDataRow["IdGaleria"];
                this.IdEstado = (int)objDataRow["IdEstado"];
                
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Nicho_Seleccionar", OpcionSeleccionar, this.NumeroNicho);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Nicho_InsertarActualizarEliminar", OpcionMantenimiento,
               this.id_Nicho, this.NumeroNicho, this.N_NumeroNicho, this.IdTamanoNicho,  this.IdGaleria, this.IdEstado);

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Nicho == 0) { return null; }//valida que el id sea diferente de cero
            if (this.NumeroNicho == null || this.NumeroNicho == "") { return null; }//valida que el descrip no sea vacío
            return string.Format("Id: {0} Número: {1} Tamaño: {1} Galería: {1}", this.id_Nicho, this.NumeroNicho, this.IdTamanoNicho, this.IdGaleria);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
    }


