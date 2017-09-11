using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace AccesoDatos
{
    public class AccesoDatos
    {
        //string CadenaConexion = @"Data Source=DESKTOP-9SE709L\SQLEXPRESS;Initial Catalog = Cementerio; Integrated Security = True";
        string CadenaConexion = @"Data Source=JUANPABLO-PC\SQLEXPRESS;Initial Catalog=Cementerio;Persist Security Info=True; Integrated Security = True";
        //string CadenaConexion = @"Data Source=SERVIDOR\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300";


        public DataTable EjecutarConsultas(string query)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))
            {
                using (DataTable objDataTabla = new DataTable())
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.Text;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = query;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos 
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.                                
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public DataTable EjecutarProcedimientosConsultas(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }
        ////Usp_Cementerio_TrasladoExtConsultas_Seleccionar
        public DataTable EjecutarTrasladoExtConsultas(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }
        public DataTable EjecutarConsultaNorteSeleccionar(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public DataTable EjecutarConsultaOesteSeleccionar(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public DataTable EjecutarConsultaJardinSeleccionar(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public DataTable EjecutarTrasladoExtConsultasSeleccionar(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }
        public DataTable EjecutarProcedimientosReporte(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

    

        public DataTable EjecutarProcedimientosHistorico(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public DataTable EjecutarConsultaNomenclatura(string StoreProcedure, params object[] Parameters)//Ese array contiene todos los valores según la entidad que uses
        //Esos valores se asigna mediante un for a los parametros del procedimiento almacenado que le corresponde Todo es dinámico En cada entidad puedes ver que los métodos
        //mandan sus propiedades y se van llenando al array, Antes del array esta el que toma el nombre del procedimiento almacenado Seguido de ello está el array que recibe 
        //las propiedades de la entidad, Dentro de cada clase, en los métodos, usas los métodos del data access Allí mandas el nombre del procedimiento y luego llenas 
        //el array con las propiedades, En Ese orden que pones las propiedades, es el mismo que tienen los parámetros del procedimiento almacenado
        //(en este array parameter estan todos los parametros).
        {
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//defino mi cadena de conexión
            {
                using (DataTable objDataTabla = new DataTable())//creo una tabla virtual el cual va a tener todos los datos del select
                {
                    using (SqlCommand objSqlCommand = new SqlCommand())//creo el comando que ejecutar el procedimiento almacenado
                    {
                        using (SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter())//creo el adaptador que asignará el resultado del select a mi tabla virtual
                        {
                            try
                            {
                                objSqlCommand.Connection = objSqlConnection;//asigno la conexo con el comando ejecutador.
                                objSqlCommand.CommandType = CommandType.StoredProcedure;//indico al comando ejecutador que sera de tipo procedimiento almacenado.
                                objSqlCommand.CommandText = StoreProcedure;//le indico al comando ejecutador el nomnbre del procedimiento almacenado
                                objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//le indico un tiempo de espera.
                                objSqlConnection.Open();//abro la conexion con el servidor y la base de datos
                                SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtengo los parametros del procedimiento almacenado
                                int i = 1;
                                foreach (object Param in Parameters)//asigno los valores de mis propiedades cargadas en la clase entidad
                                {
                                    objSqlCommand.Parameters[i].Value = Param;//igualo cada parametro de mi procedimiento almacenado con cada parametro de las propiedades que estan en "Parameters"
                                    i += 1;
                                }
                                objSqlDataAdapter.SelectCommand = objSqlCommand;//asigno al adaptador el comonado ejecutador
                                objSqlDataAdapter.Fill(objDataTabla);//obtengo el resultado del select y lo asigno a la tabla virtual
                                objSqlConnection.Close();//cierro la conexion con el servidor y base de datos
                                return objDataTabla;//finalmente retorno la tabla virtual con el resultado del select.
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                objSqlConnection.Close();
                            }
                        }
                    }
                }
            }
        }

        public int EjecutarProcedimientoInsertarActualizarEliminar(string StoreProcedure, params object[] Parameters)
        {
            int resultado = 0;//creo una variable que obtendrá el resultado el procedimiento, el output.
            using (SqlConnection objSqlConnection = new SqlConnection(this.CadenaConexion))//conexion
            {
                using (SqlCommand objSqlCommand = new SqlCommand())//comando ejecutador
                {
                    try
                    {
                        objSqlCommand.Connection = objSqlConnection;//asigno la conexion al comando
                        objSqlCommand.CommandType = CommandType.StoredProcedure;//le indico el tipo de comando
                        objSqlCommand.CommandText = StoreProcedure;//le doy el nombre del procedimiento almacenado
                        //Establesco el tiempo de espera en 5 minutos
                        objSqlCommand.CommandTimeout = objSqlConnection.ConnectionTimeout;//el tiempo de espera, no es muy importante, cuando lo necesites lo veremos.
                        objSqlConnection.Open();//abrimos conxion
                        SqlCommandBuilder.DeriveParameters(objSqlCommand);//obtenemos los parametros de entrada del procedimiento almacenado
                        int i = 0;
                        for (i = 0; i <= Parameters.Length - 1; i++)
                        {
                            ((SqlParameter)objSqlCommand.Parameters[i + 1]).Value = Parameters[i];//asignamos propiedades de entidad dentro del array "parameters" con los parametros del procedimiento.
                        }
                        resultado = Convert.ToInt32(objSqlCommand.ExecuteNonQuery());//aqui se ejecuta el procedimiento y se obtniene un resultado, aun no obenemos el ouput, solo un resultado por defecto que manda el sql.
                        objSqlConnection.Close();//cerramos la conexion
                        IDataParameter ObjIDataParameter = null;//creamos una variable de tipo parametro
                        foreach (IDataParameter ObjDataParameter in objSqlCommand.Parameters)//vamos a recorrer los parametros obtenido con el comando ejecutador para ubicar el parametro output
                        {
                            ObjIDataParameter = ObjDataParameter;
                            if (ObjIDataParameter.Direction == ParameterDirection.InputOutput | ObjIDataParameter.Direction == ParameterDirection.Output)//aqui comparamos e identificamos el parametro OUTPUT
                            {
                                return Convert.ToInt32(ObjIDataParameter.Value);//aqui obtengo el OUTPUT con el resultado del insert,update o delete.
                            }
                        }
                        return resultado;//si no tiene parametro de salida OUTPUT, retornara el valor por defecto que retorna el sql.
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                }
            }
        }

    }
}
