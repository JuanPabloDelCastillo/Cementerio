using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Laboratorio3.Librerias
{
    class Pintar
    {
        private static Color ColorConFoco = Color.Beige;
        private static Color ColorSinFoco = Color.White;

        public static void ConFoco(object sender)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = ColorConFoco;
            }
            else if (sender is ComboBox)
            {
                ((ComboBox)sender).BackColor = ColorConFoco;
            }
            else if (sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = ColorConFoco;
            }
        }

        public static void SinFoco(object sender)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = ColorSinFoco;
            }
            else if (sender is ComboBox)
            {
                ((ComboBox)sender).BackColor = ColorSinFoco;
            }
            else if (sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = ColorSinFoco;
            }
        }

        public static void Titulo(object sender)
        {
            ((Label)sender).ForeColor = Color.Beige;
        }

        public static void SubTitulo(object sender)
        {
            ((Label)sender).ForeColor = Color.LightGray;
        }
    }
}
