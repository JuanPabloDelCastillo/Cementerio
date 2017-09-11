using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Banco
{
    //CLASE PARA QUE SOLO EL GERENTE VEA LAS CONTRASEÑAS TE TODOS
    class ClasConfidencial
    {
        //////claves de empleados
        public void ClavesEmpleados(DataGridView data)
        {

            string consulta = "Select ID_EMPLEADO,NOMBRE_EMPLEADO,CLAVE_EMPLEADO from EMPLEADO WHERE MBAJA=1";

            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.Connection = cn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 40;
            data.Columns[0].HeaderCell.Value = "Id";
            data.Columns[1].Width = 140;
            data.Columns[1].HeaderCell.Value = "Nombres";
            data.Columns[2].Width = 130;
            data.Columns[2].HeaderCell.Value = "Contraseñas";

            cn.Close();
        }

        //////claves de clientes
        public void ClavesClientes(DataGridView data)
        {

            string consulta = "Select ID_CLIENTE,NOMBRE_CLIENTE,CLAVE_CLIENTE from CLIENTE WHERE MBAJA=1";

            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.Connection = cn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 40;
            data.Columns[0].HeaderCell.Value = "Id";
            data.Columns[1].Width = 140;
            data.Columns[1].HeaderCell.Value = "Nombres";
            data.Columns[2].Width = 130;
            data.Columns[2].HeaderCell.Value = "Contraseñas";

            cn.Close();
        }
    }
}
