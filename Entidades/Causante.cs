using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data;
//using System.Windows.Controls;

namespace Entidades
{
    public class Causante
    {
        #region"Constructor"
        public Causante()
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        //public string Edad_Meses { get; set; }
        public string Nacionalidad { get; set; }
        public string Folio { get; set; }
        public DateTime FechaHora_Fall { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Inhum { get; set; }
        public string Observaciones { get; set; }
        //public string Responsable { get; set; }
        public byte[] Foto { get; set; }
        public int id_Construccion { get; set; }
        public int id_NConstrucc { get; set; }
        public int id_Empleado { get; set; }
        public int id_Empresa { get; set; }
        public string NumeroNicho { get; set; }
        public int id_Nomenc { get; set; }
        public int id_Tramite { get; set; }
        public int CODIGO { get; set; }
        public bool? TrasladoExterno { get; set; }
        #endregion

        #region"Relacion entre clases"
        private Nomenc _Nomenc;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public Nomenc Nomenc//Propiedad de tipo Nomenc que mostrar todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Nomenc != 0 )//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Nomenc objNomenc = new Nomenc();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objNomenc.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                    objNomenc.Seleccionar();//aplico la busqueda en la base de datos
                    this._Nomenc = objNomenc;//asigno el resultado a la variable interna
                }
                return this._Nomenc;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private NomencCausante _NomencCausante;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public NomencCausante NomencCausante//Propiedad de tipo Nomenc que mostrar todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                //if (this.id_Nomenc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                //{
                    NomencCausante objNomencNomencCausate = new NomencCausante();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objNomencNomencCausate.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                    objNomencNomencCausate.Dni = this.Dni;
                    objNomencNomencCausate.Seleccionar();//aplico la busqueda en la base de datos
                    this._NomencCausante = objNomencNomencCausate;//asigno el resultado a la variable interna
                //}
                return this._NomencCausante;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private TrasladoExt _Traslado;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public TrasladoExt Traslado//Propiedad de tipo Nomenc que mostrar todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                //if (this.id_Nomenc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                //{
                TrasladoExt objTraslado = new TrasladoExt();//creo una variable y lo instancio para  obtener los datos del nomenc
                objTraslado.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                objTraslado.Dni = this.Dni;
                objTraslado.Seleccionar();//aplico la busqueda en la base de datos
                this._Traslado = objTraslado;//asigno el resultado a la variable interna
                //}
                return this._Traslado;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private TrasladoInt _TrasladoInt;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public TrasladoInt TrasladoInt//Propiedad de tipo Nomenc que mostrar todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                //if (this.id_Nomenc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                //{
                TrasladoInt objTrasladoInt = new TrasladoInt();//creo una variable y lo instancio para  obtener los datos del nomenc
                objTrasladoInt.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                objTrasladoInt.Dni = this.Dni;
                objTrasladoInt.Seleccionar();//aplico la busqueda en la base de datos
                this._TrasladoInt = objTrasladoInt ;//asigno el resultado a la variable interna
                //}
                return this._TrasladoInt;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

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

        private Empresa _Empresa;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public Empresa Empresa//Propiedad de tipo Nomenc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Empresa != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Empresa objEmpresa = new Empresa();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objEmpresa.id_Empresa = this.id_Empresa;//le asigno el id que es diferente de 0
                    objEmpresa.Seleccionar();//aplico la busqueda en la base de datos
                    this._Empresa = objEmpresa;//asigno el resultado a la variable interna
                }
                return this._Empresa;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private Empleado _Empleado;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public Empleado Empleado//Propiedad de tipo Nomenc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Empleado != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Empleado objEmpleado = new Empleado();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objEmpleado.id_Empleado = this.id_Empleado;//le asigno el id que es diferente de 0
                    objEmpleado.Seleccionar();//aplico la busqueda en la base de datos
                    this._Empleado = objEmpleado;//asigno el resultado a la variable interna
                }
                return this._Empleado;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }
  //      #endregion


        private Construcc_Tipo _Construcc_Tipo;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        public Construcc_Tipo Construcc_Tipo//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Construccion != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Construcc_Tipo objConstrucc = new Construcc_Tipo();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objConstrucc.id_Nomenc = this.id_Nomenc;//le asigno el id que es diferente de 0
                    objConstrucc.id_Construccion = this.id_Construccion;//le asigno el id que es diferente de 0
                    objConstrucc.Seleccionar();//aplico la busqueda en la base de datos
                    this._Construcc_Tipo = objConstrucc;//asigno el resultado a la variable interna
                }
                return this._Construcc_Tipo;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private NConstrucc _NConstrucc;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        public NConstrucc NConstrucc//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_NConstrucc != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    NConstrucc objNConstrucc = new NConstrucc();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objNConstrucc.id_NConstrucc = this.id_NConstrucc;//le asigno el id que es diferente de 0
                    objNConstrucc.Seleccionar();//aplico la busqueda en la base de datos
                    this._NConstrucc = objNConstrucc;//asigno el resultado a la variable interna
                }
                return this._NConstrucc;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        private Tramite _Tramite;//Variable de tipo Tramite que capturara el resultado de la busqueda en la base de datos
        public Tramite Tramite//Propiedad de tipo Tramite que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Tramite != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Tramite objTramite = new Tramite();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objTramite.id_Tramite = this.id_Tramite;//le asigno el id que es diferente de 0
                    objTramite.Seleccionar();//aplico la busqueda en la base de datos
                    this._Tramite = objTramite;//asigno el resultado a la variable interna
                }
                return this._Tramite;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }
        
        private Nicho _Nicho;//Variable de tipo Nicho que capturara el resultado de la busqueda en la base de datos
        public Nicho Nicho//Propiedad de tipo Nicho que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.NumeroNicho != "")//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Nicho objNicho = new Nicho();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objNicho.NumeroNicho = this.NumeroNicho;//le asigno el id que es diferente de 0
                    objNicho.Seleccionar();//aplico la busqueda en la base de datos
                    this._Nicho = objNicho;//asigno el resultado a la variable interna
                }
                return this._Nicho;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        //private TamanoNicho _TamanoNicho;//Variable de tipo Nicho que capturara el resultado de la busqueda en la base de datos
        //public TamanoNicho TamanoNicho//Propiedad de tipo Nicho que mostrará todas las caracteristicas de la clase.
        //{
        //    get//método que pertenece a la propiedad, sirve para mostrar un resultado.
        //    {
        //        if (this.Id != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
        //        {
        //            TamanoNicho objTamanoNicho = new TamanoNicho();//creo una variable y lo instancio para  obtener los datos del nomenc
        //            objTamanoNicho.IdTamanoNicho = this.id;//le asigno el id que es diferente de 0
        //            objTamanoNicho.Seleccionar();//aplico la busqueda en la base de datos
        //            this._TamanoNicho = objTamanoNicho;//asigno el resultado a la variable interna
        //        }
        //        return this._TamanoNicho;//retorno una variable de la misma clase el cual se podra ver como propiedad.
        //    }
        //}
        public DataTable MostrarNomenclatura()
        {
            return EjecutarConsultaNomenclatura("T");
        }
        private DataTable EjecutarConsultaNomenclatura(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarConsultaNomenclatura("Usp_Cementerio_NomencConsulta_por_Nomenclatura", OpcionSeleccionar,  this.id_Nomenc);
        }


        private USUARIOS _USUARIOS;//Variable de tipo Constrcc que capturara el resultado de la busqueda en la base de datos
        public USUARIOS USUARIOS//Propiedad de tipo Construcc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.CODIGO != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    USUARIOS objUsuarios = new USUARIOS();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objUsuarios.CODIGO = this.CODIGO;//le asigno el id que es diferente de 0
                    objUsuarios.Seleccionar();//aplico la busqueda en la base de datos
                    this._USUARIOS = objUsuarios;//asigno el resultado a la variable interna
                }
                return this._USUARIOS;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        public object TamanoNicho { get; set; }
        #endregion

        #region"Validar"
        /// No permitir ingresar Numeros
        /// </summary>
        /// <param name="parent"></param>


        #endregion

        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.Dni = objDataRow["Dni"].ToString();
                this.Nombre = objDataRow["Nombre"].ToString();
                this.Edad = objDataRow["Edad"].ToString();
                //this.Edad_Meses = objDataRow["Edad_Meses"].ToString();
                this.Nacionalidad = objDataRow["Nacionalidad"].ToString();
                this.Folio = objDataRow["Folio"].ToString();
                this.FechaHora_Fall = (DateTime)objDataRow["FechaHora_Fall"];
                this.Sexo = objDataRow["Sexo"].ToString();
                this.Fecha_Inhum = (DateTime)objDataRow["Fecha_Inhum"];
                this.Observaciones = objDataRow["Observaciones"].ToString();
                //this.Responsable = objDataRow["Responsable"].ToString();
                this.Foto = string.IsNullOrEmpty(objDataRow["Foto"].ToString()) ? null : (byte[])objDataRow["Foto"];
                this.id_Construccion = (int)objDataRow["id_Construccion"];
                this.id_NConstrucc = (int)objDataRow["id_NConstrucc"];
                this.id_Empleado = (int)objDataRow["id_Empleado"];
                this.id_Empresa = (int)objDataRow["id_Empresa"];
                this.NumeroNicho = objDataRow["NumeroNicho"].ToString();
                this.id_Nomenc = (int)objDataRow["id_Nomenc"];
                this.id_Tramite = (int)objDataRow["id_Tramite"];
                this.CODIGO = (int)objDataRow["CODIGO"];
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }
        public int MarcarTrasladoExterno(string dni)
        {
            string query = string.Format("Update Causante Set TrasladoExterno = 1 Where Dni = {0}", dni);
            DataTable table = new AccesoDatos.AccesoDatos().EjecutarConsultas(query);
            return table.Rows.Count;
        }

        public DataTable MostrarCausantesSinTrasladosExt()
        {
            string query = "Select * From Causante Where TrasladoExterno IS NULL OR TrasladoExterno = 0";
            return new AccesoDatos.AccesoDatos().EjecutarConsultas(query);
        }

        public DataTable MostrarCausantes()
        {
            return this.EjecutarConsulta("TC");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Causante_Seleccionar", OpcionSeleccionar, this.Dni);
        }

        public DataTable MostrarCausantesNorte()
        {
            return this.EjecutarConsultaNorteSeleccionar("T");
        }
        public DataTable EjecutarConsultaNorteSeleccionar(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarConsultaNorteSeleccionar("Usp_Cementerio_CausanteNorte_Seleccionar", OpcionSeleccionar, this.Dni);
        }

        public DataTable MostrarCausantesOeste()
        {
            return this.EjecutarConsultaOesteSeleccionar("T");
        }
        public DataTable EjecutarConsultaOesteSeleccionar(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarConsultaNorteSeleccionar("Usp_Cementerio_CausanteOeste_Seleccionar", OpcionSeleccionar, this.Dni);
        }

        public DataTable MostrarCausantesJardin()
        {
            return this.EjecutarConsultaJardinSeleccionar("T");
        }
        public DataTable EjecutarConsultaJardinSeleccionar(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarConsultaNorteSeleccionar("Usp_Cementerio_CausanteJardin_Seleccionar", OpcionSeleccionar, this.Dni);
        }

        public DataTable MostrarCausantesTrasladosExt()
        {
            return this.EjecutarCausanteTrasladoExtSeleccionar("T");
        }
        public DataTable EjecutarCausanteTrasladoExtSeleccionar(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarTrasladoExtConsultas("Usp_Cementerio_CausanteTrasladoExtSeleccionar", OpcionSeleccionar, this.Dni);
        }


        public DataTable MostrarHistorico()
        {
            return this.EjecutarHistorico("T");
        }
        private DataTable EjecutarHistorico(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosHistorico("Usp_Cementerio_CausanteHistorico_Seleccionar", OpcionSeleccionar, this.Dni);
        }

        //public DataTable MostrarNomenclatura()
        //{
        //    return EjecutarConsultaNomenclatura("T");
        //}
        //private DataTable EjecutarConsultaNomenclatura(string OpcionSeleccionar)
        //{
        //    return new AccesoDatos.AccesoDatos().EjecutarConsultaNomenclatura("Usp_Cementerio_NomencConsulta_por_Nomenclatura", OpcionSeleccionar, this.id_Nomenc);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Causante_InsertarActualizarEliminar", OpcionMantenimiento,
                this.Dni, this.Nombre, this.Edad, this.Nacionalidad, this.Folio, this.FechaHora_Fall, this.Sexo, this.Fecha_Inhum, this.Observaciones,
                 this.Foto, this.id_Construccion, this.id_NConstrucc, this.id_Empleado, this.id_Empresa, this.NumeroNicho, this.id_Nomenc, this.id_Tramite, this.CODIGO);
            
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.Dni == null || this.Dni == "") { return null; }
            if (this.Nombre == null || this.Nombre == "") { return null; }
            return string.Format("DNI: {0} Nombre: {1}", this.Dni, this.Nombre);
        }
        #endregion
    }
}
