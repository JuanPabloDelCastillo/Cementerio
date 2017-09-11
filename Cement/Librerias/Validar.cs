using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio3.Librerias
{
    class Validar
    {
        public Validar()
        { }

        ~Validar()
        { }

        public static string VerificarCaracteres(string _Cadena)
        {
            string Valor = _Cadena;

            Valor.Replace("'", " ");
            Valor.Replace("=", " ");
            return Valor;
        }

        public void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }

        }
        public void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }
        }

        public void NoSimbolos(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }

        }

        public void Mouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                MessageBox.Show("No se puede hacer Click", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void VerificarNoVacios(object sender, EventArgs e, ErrorProvider error)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                error.SetError(((TextBox)sender), "");
            }
            else
            {
                error.SetError(((TextBox)sender), "Dato Obligatorio");
            }
        }

        public void SinAcceso(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }

        }
        //Agregado por Juan

        public void NoPegar(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 22 || Convert.ToInt32(e.KeyChar) == 93)
            {
                e.Handled = true;
            }

        }

        public void NoPegarTecla(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyValue) == 93)
            {
                e.Handled = true;
            }

        }


        public void NoInyeccion(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ';' || e.KeyChar == '+' || e.KeyChar == '"' || (int)e.KeyChar == 39)
            {
                e.Handled = true;
            }

        }
    }
}
