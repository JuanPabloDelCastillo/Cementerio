using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entidades
{
    public class Empleado//todas las clases entidades deben ser públicas
    {
        #region"Constructor"
        public Empleado()//el constructor siempre tiene el mismo nombre que la clase.
            : base()
        { 
        
        }
        #endregion

        #region"Propiedades"
        public int id_Empleado { get; set; }
        public string Dni { get; set; }
        public string Nombre_E { get; set; }
        public string Calle { get; set; }
        public string Calle_Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int id_Empleado_Tipo { get; set; }
        public int id_Usuario { get; set; }
        
        public string Cuil { get; set; }
        public string Afiliado_Num { get; set; }
        public byte[] Foto { get; set; }
        public string Turno { get; set; }
        #endregion

        #region"Relacion entre clases"
        private Empleado_Tipo _Empleado_Tipo;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        public Empleado_Tipo Empleado_Tipo//Propiedad de tipo Nomenc que mostrará todas las caracteristicas de la clase.
        {
            get//método que pertenece a la propiedad, sirve para mostrar un resultado.
            {
                if (this.id_Empleado_Tipo != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
                {
                    Empleado_Tipo objEmpleado_Tipo = new Empleado_Tipo();//creo una variable y lo instancio para  obtener los datos del nomenc
                    objEmpleado_Tipo.id_Empleado_Tipo = this.id_Empleado_Tipo;//le asigno el id que es diferente de 0
                    objEmpleado_Tipo.Seleccionar();//aplico la busqueda en la base de datos
                    this._Empleado_Tipo = objEmpleado_Tipo;//asigno el resultado a la variable interna
                }
                return this._Empleado_Tipo;//retorno una variable de la misma clase el cual se podra ver como propiedad.
            }
        }

        //private USUARIOS _USUARIOS;//Variable de tipo Nomenc que capturara el resultado de la busqueda en la base de datos
        //public USUARIOS USUARIOS//Propiedad de tipo Nomenc que mostrará todas las caracteristicas de la clase.
        //{
        //    get//método que pertenece a la propiedad, sirve para mostrar un resultado.
        //    {
        //        if (this.CODIGO != 0)//si el id es difirente de 0 procederá a buscar en la base de datos mediante el metodo Seleccionar de la clase.
        //        {
        //            USUARIOS objUSUARIOS = new USUARIOS();//creo una variable y lo instancio para  obtener los datos del nomenc
        //            objUSUARIOS.CODIGO = this.CODIGO;//le asigno el id que es diferente de 0
        //            objUSUARIOS.Seleccionar();//aplico la busqueda en la base de datos
        //            this._USUARIOS = objUSUARIOS;//asigno el resultado a la variable interna
        //        }
        //        return this._USUARIOS;//retorno una variable de la misma clase el cual se podra ver como propiedad.
        //    }
        //}
        #endregion


        #region"Metodos"
        public void Seleccionar()
        {
            DataTable objDataTable = this.EjecutarConsulta("S");
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.id_Empleado = (int)objDataRow["id_Empleado"];
                this.Dni = objDataRow["Dni"].ToString();
                this.Nombre_E = objDataRow["Nombre_E"].ToString();
                this.Calle = objDataRow["Calle"].ToString();
                this.Calle_Numero = objDataRow["Calle_Numero"].ToString();
                this.Piso = objDataRow["Piso"].ToString();
                this.Departamento = objDataRow["Departamento"].ToString();
                this.Telefono = objDataRow["Telefono"].ToString();
                this.Celular = objDataRow["Celular"].ToString();
                this.Email = objDataRow["Email"].ToString();
                this.Fecha_Ingreso = (DateTime)objDataRow["Fecha_Ingreso"];
                this.Cuil = objDataRow["Cuil"].ToString();
                this.Afiliado_Num = objDataRow["Afiliado_Num"].ToString();
                this.Foto = string.IsNullOrEmpty(objDataRow["Foto"].ToString()) ? null : (byte[])objDataRow["Foto"];
                this.Turno = objDataRow["Turno"].ToString();
                this.id_Empleado_Tipo = (int)objDataRow["id_Empleado_Tipo"];
                this.id_Usuario = (int)objDataRow["id_Usuario"];
            }
        }

        public DataTable MostrarTodos()
        {
            return this.EjecutarConsulta("T");
        }

        private DataTable EjecutarConsulta(string OpcionSeleccionar)
        {
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_Empleado_Seleccionar", OpcionSeleccionar, this.Dni);
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
            return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_Empleado_InsertarActualizarEliminar", OpcionMantenimiento,
                this.id_Empleado, this.Dni, this.Nombre_E, this.Calle, this.Calle_Numero, this.Piso, this.Departamento, this.Telefono, this.Celular, this.Email, this.Fecha_Ingreso, this.Cuil, this.Afiliado_Num, this.Foto, this.Turno, this.id_Empleado_Tipo, this.id_Usuario);
            
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()//este método sirve para mostrar la descripción de una clase.
        {
            if (this.Dni == null || this.Dni == "") { return null; }
            if (this.Nombre_E == null || this.Nombre_E == "") { return null; }
            return string.Format("DNI: {0} Nombre: {1}", this.Dni, this.Nombre_E);
            //if (this.id_Empleado == 0) { return null; }//valida que el id sea diferente de cero
            //if (this.Nombre_E == null || this.Nombre_E == "") { return null; }//valida que el descrip no sea vacío
            //return string.Format("Id: {0} Nombre: {1}", this.id_Empleado, this.Nombre_E);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
        }
        #endregion
    }
}

    

