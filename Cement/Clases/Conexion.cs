using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cement
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            //SqlConnection conectar = new SqlConnection(@"Data Source=DESKTOP-9SE709L\SQLEXPRESS;Initial Catalog = Cementerio; Integrated Security = True");
            SqlConnection conectar = new SqlConnection(@"Data source=JUANPABLO-PC\SQLEXPRESS;DataBase=Cementerio;Integrated Security=SSPI");
            //SqlConnection conectar = new SqlConnection(@"Data Source=192.168.1.200;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300");
            //SqlConnection conectar = new SqlConnection(@"Data Source=SERVIDOR\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300");
            //"Data Source=SERVIDOR\\SQL2008;Initial Catalog=Cementerio;Persist Security Info=True;User ID=sa;Password=bsas386;Connect Timeout=300";//servidor Direccion
            conectar.Open();
            return conectar;

        }
    }
}
