using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cement
{
    class Acceso
    {
        //SqlConnection miconexion = new SqlConnection(Conexion.conexion);

        private string mensaje;
        private string usuario;
        private string clave;
        private string tipo;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public bool Verificar()
        {
            bool resultado = false;
            SqlCommand comando = new SqlCommand("select * from USUARIOS where NOMBREU='" + Usuario + "'and CLAVE='" + Clave + "'and TIPO='" + Tipo + "'", Conexion.ObtenerConexion());
            SqlDataReader ejecuta = comando.ExecuteReader();
            if (ejecuta.Read())
            {
                resultado = true;
                mensaje = "Su Logueo Fue Ingresado Correctamente \n \n               Bienvenido al Sistema \n \n de Tarjetas de Banco";
            }
            else
            {
                mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
            }
            return resultado;
        }
    }
}
