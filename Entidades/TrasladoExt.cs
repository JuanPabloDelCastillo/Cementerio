using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TrasladoExt
    {
        #region"Constructor"
        public TrasladoExt()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        {

        }
        #endregion

        #region"Propiedades"
        public int id_Nomenc { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Codcem { get; set; }
        public string Cuadro { get; set; }
        public string Zona { get; set; }
        public string Lote { get; set; }



        //public string N_Codcem { get; set; }
        //public string N_Cuadro { get; set; }
        //public string N_Zona { get; set; }
        //public string N_Lote { get; set; }
        //public string N_Seccion { get; set; }
        public string Seccion { get; set; }
        public string OtroCem { get; set; }
        public int id_Construccion { get; set; }
        public string Nombre_C { get; set; }
        //public int id_NConstrucc { get; set; }
        //public string NCNombre { get; set; }
        public string TamNicho { get; set; }
        public string Galeria { get; set; }
        public string Nicho_Numero { get; set; }
        public string Nombre_Emp { get; set; }
        public string Nombre_TipoTramite { get; set; }
        public DateTime Fecha_Traslado { get; set; }
        public string Observaciones { get; set; }
        public Boolean Estado { get; set; }
        #endregion

        #region "Relaciones"
        private Construcc_Tipo _Construcc_Tipo;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        public Construcc_Tipo Construcc_Tipo//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Construccion != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Construcc_Tipo objConstrucc = new Construcc_Tipo();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objConstrucc.id_Construccion = this.id_Construccion;//le asigno el id que es diferente de 0
                    objConstrucc.Seleccionar();//aplico la busqueda en la base de datos
                    this._Construcc_Tipo = objConstrucc;//asigno el resultado a la variable interna
                }
                return this._Construcc_Tipo;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        //private NConstrucc _NConstrucc;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        //public NConstrucc NConstrucc//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        //{
        //    get//método que pertenece a la propiedad, sirve para mostrar un resultado.
        //    {
        //        if (this.id_NConstrucc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
        //        {
        //            NConstrucc objNConstrucc = new NConstrucc();//creo una variable y lo instancio para  obtener los datos del nomenc
        //            objNConstrucc.id_NConstrucc = this.id_NConstrucc;//le asigno el id que es diferente de 0
        //            objNConstrucc.Seleccionar();//aplico la busqueda en la base de datos
        //            this._NConstrucc = objNConstrucc;//asigno el resultado a la variable interna
        //        }
        //        return this._NConstrucc;//retorno una variable de la misma clase el cual se podra ver como propiedad.
        //    }
        //}

        private Historico _Historico;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        public Historico Historico//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Nomenc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Historico objHistorico = new Historico();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objHistorico.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                    objHistorico.Seleccionar();//aplico la busqueda en la base de datos
                    this._Historico = objHistorico;//asigno el resultado a la variable interna
                }
                return this._Historico;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }
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
                    this.Nombre = objDataRow["Nombre"].ToString();
                    this.Codcem = objDataRow["Codcem"].ToString();
                    this.Cuadro = objDataRow["Cuadro"].ToString();
                    this.Zona = objDataRow["Zona"].ToString();
                    this.Lote = objDataRow["Lote"].ToString();
                    //this.N_Codcem = objDataRow["N_Codcem"].ToString();
                    //this.N_Cuadro = objDataRow["N_Cuadro"].ToString();
                    //this.N_Zona = objDataRow["N_Zona"].ToString();
                    //this.N_Lote = objDataRow["N_Lote"].ToString();
                    //this.N_Seccion = objDataRow["N_Seccion"].ToString();
                    this.Seccion = objDataRow["Seccion"].ToString();
                    this.OtroCem = objDataRow["OtroCem"].ToString();
                    this.id_Construccion = (int)objDataRow["id_Construccion"];
                    this.Nombre_C = objDataRow["Nombre_C"].ToString();
                    //this.id_NConstrucc = (int)objDataRow["id_NConstrucc"];
                    //this.NCNombre = objDataRow["NCNombre"].ToString();
                    this.TamNicho = objDataRow["TamNicho"].ToString();
                    this.Galeria = objDataRow["Galeria"].ToString();
                    this.Nicho_Numero = objDataRow["Nicho_Numero"].ToString();
                    this.Nombre_Emp = objDataRow["Nombre_Emp"].ToString();
                    this.Nombre_TipoTramite = objDataRow["Nombre_TipoTramite"].ToString();
                    this.Fecha_Traslado = (DateTime)objDataRow["Fecha_Traslado"];
                    this.Observaciones = objDataRow["Observaciones"].ToString();
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_TrasladoExt_Seleccionar", OpcionSeleccionar, this.id_Nomenc, this.Dni);
        }

        //public DataTable MostrarTrasladosExt()
        //{
        //    return this.EjecutarTrasladoExtConsultas("TE");
        //}
        //public DataTable EjecutarTrasladoExtConsultas(string OpcionSeleccionar)
        //{
        //    return new AccesoDatos.AccesoDatos().EjecutarTrasladoExtConsultas("Usp_Cementerio_TrasladoExtConsultas_Seleccionar", OpcionSeleccionar, this.id_Nomenc, this.Dni);
        //}

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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_TrasladoExt_InsertarActualizarEliminar", OpcionMantenimiento,
                this.id_Nomenc, this.Dni, this.Nombre, this.Codcem, this.Cuadro, this.Zona, this.Lote, this.Seccion, this.OtroCem, this.id_Construccion, this.Nombre_C,  this.TamNicho, this.Galeria,
                this.Nicho_Numero, this.Nombre_Emp, this.Nombre_TipoTramite, this.Fecha_Traslado, this.Observaciones, this.Estado);
        }
         //this.N_Codcem, this.N_Cuadro, this.N_Zona, this.N_Lote, this.N_Seccion,
         //this.id_NConstrucc, this.NCNombre,
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.id_Nomenc == 0) { return null; }//valida que el id sea diferente de cero
            if (this.Codcem == null || this.Codcem == "") { return null; }//valida que el codcem no sea vacío
            return string.Format("Id: {0} Nombre: {1}", this.id_Nomenc, this.Codcem);
            #endregion
        }
    }
}
