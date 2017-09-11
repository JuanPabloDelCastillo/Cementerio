using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cement
{
    class USUARIOS
    {
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

         public USUARIOS(int cod, string nom, string cla, string tip)
        {
            Codigo = cod;
            Nombre = nom;
            Clave = cla;
            Tipo = tip;
        }

         public USUARIOS()
        {
            Codigo = 0;
            Nombre = "";
            Clave = "";
            Tipo = "";
        }


        //METODO AGREGAR PERSONA
        public static bool Agregar(USUARIOS usu)
         {

             SqlCommand sql = new SqlCommand("MANTENIMIENTO", Conexion.ObtenerConexion());
             sql.CommandType = CommandType.StoredProcedure;

             sql.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 200).Value = usu.Nombre;
             sql.Parameters.Add("@CLAVE", SqlDbType.VarChar, 200).Value = usu.Clave;
             sql.Parameters.Add("@TIPO", SqlDbType.VarChar, 200).Value = usu.Tipo;

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

         //LISTA FORMULARIO PERSONAS
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
             data.Columns[0].Width = 74;
             data.Columns[0].HeaderCell.Value = "CODIGO";
             data.Columns[1].Width = 110;
             data.Columns[1].HeaderCell.Value = "NOMBRE";
             data.Columns[2].Width = 95;
             data.Columns[2].HeaderCell.Value = "CLAVE";
             data.Columns[3].Width = 130;
             data.Columns[3].HeaderCell.Value = "TIPO";

         }
    }
}
