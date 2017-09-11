using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio3.Librerias
{
    public class Configuracion
    {
        public enum Ocupacion
        {
            ADMINISTRATIVO,
            PEDIATRIA            
        }

        public enum Especialidad
        {            
            PEDIATRIA
        }

        public enum Dia
        {
            Sat, // Sabado
            Sun, // Domingo
            Mon, // lunes
            Tue, // Martes
            Wed, // Miercoles
            Thu, // Jueves
            Fri  // Viernes
        }

        public enum TipoIngreso
        {
            NORMAL,
            URGENCIA,
            FUERA_TURNO
        }

        public enum Tipo
        {
            TURNO,
            LLEGADA
        }

        public void PoblarCmbTipo(ComboBox cmb)
        {
            cmb.DataSource = System.Enum.GetValues(typeof(Tipo));
        }
    }
}
