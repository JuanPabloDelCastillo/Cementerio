using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cement
{
    class Service
    {
            private int v1;
            private string nom;
            private string v2;

            //PARAMETROS, CONTRUCTORES
            public int Codigo
            {
                get;
                set;
            }
            public string Nombre
            {
                get;
                set;
            }
            public string Clave
            {
                get;
                set;
            }

        public string Tipo
        {
            get;
            set;
        }
        public Service(int codigo, string nombreu, string clave, string tipo)
            {
                Codigo = codigo;
                Nombre = nombreu;
                Clave = clave;
                Tipo = tipo;
        }
            public Service()
            {
                Codigo = 0;
                Nombre = "";
                Clave = "";
                Tipo = "";
        }

        public Service(int v1, string nom, string v2)
        {
            this.v1 = v1;
            this.nom = nom;
            this.v2 = v2;
        }

        //METODOS AGREGAR Usuarios
        public static bool Agregar(Service Usu)
            {

                SqlCommand sql = new SqlCommand("MANTENIMIENTO", Conexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Usu.Codigo;
                sql.Parameters.Add("@NOMBREU", SqlDbType.VarChar, 200).Value = Usu.Nombre;
                sql.Parameters.Add("@CLAVE", SqlDbType.VarChar, 200).Value = Usu.Clave;
                sql.Parameters.Add("@TIPO", SqlDbType.VarChar, 200).Value = Usu.Tipo;
                sql.Parameters.Add("@OPCION", SqlDbType.Int, 1).Value = 1;

                try
                {
                    int r = sql.ExecuteNonQuery();
                    return r > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            //METODOS MODIFICAR Usuarios
            public static bool Modificar(Service Usu)
            {
                SqlCommand sql = new SqlCommand("MANTENIMIENTO", Conexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Usu.Codigo;
                sql.Parameters.Add("@NOMBREU", SqlDbType.VarChar, 200).Value = Usu.Nombre;
                sql.Parameters.Add("@CLAVE", SqlDbType.VarChar, 200).Value = Usu.Clave;
                sql.Parameters.Add("@TIPO", SqlDbType.VarChar, 200).Value = Usu.Tipo;
                sql.Parameters.Add("@OPCION", SqlDbType.Int, 1).Value = 2;

                try
                {
                    int r = sql.ExecuteNonQuery();
                    return r > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            //METODOS ELIMINAR Usuariosl
            public static bool Eliminar(Service Usu)
            {
                SqlCommand sql = new SqlCommand("MANTENIMIENTO", Conexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Usu.Codigo;
                sql.Parameters.Add("@NOMBREU", SqlDbType.VarChar, 200).Value = Usu.Nombre;
                sql.Parameters.Add("@CLAVE", SqlDbType.VarChar, 200).Value = Usu.Clave;
                sql.Parameters.Add("@TIPO", SqlDbType.VarChar, 200).Value = Usu.Tipo;
                sql.Parameters.Add("@OPCION", SqlDbType.Int, 1).Value = 3;

                try
                {
                    int r = sql.ExecuteNonQuery();
                    return r > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            //LISTA FORMULARIO Usuarios
            public void listar(DataGridView data)
            {
                string consulta = "SELECT * FROM USUARIOS";

                SqlCommand comando = new SqlCommand(consulta, Conexion.ObtenerConexion());
                comando.Connection = Conexion.ObtenerConexion();
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].Width = 60;
                data.Columns[1].Width = 74;
                data.Columns[1].HeaderCell.Value = "CODIGO";
                data.Columns[2].Width = 110;
                data.Columns[2].HeaderCell.Value = "NOMBREU";
                data.Columns[3].Width = 95;
                data.Columns[3].HeaderCell.Value = "CLAVE";
                data.Columns[4].Width = 100;
                data.Columns[4].HeaderCell.Value = "TIPO";

        }

        }
    }

