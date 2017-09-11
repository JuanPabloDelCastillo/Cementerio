﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Laboratorio3.Librerias
{
    class Encriptar
    { // La clave tiene que tener 32 caracteres
        private static string ClaveSecreta = "1MonitorFeo_Tiene_BrilloPerfecto";

        //private static string BytesAString(byte[] bytes)  
        //{  
        //    StringBuilder str = new StringBuilder();  
        //    for (int i = 0; i < bytes.Length; i++)  
        //        str.AppendFormat("{0:x2}", bytes[i]);  
        //    return str.ToString();  
        //}  

        //public static byte[] Convertir(string sCadena)
        //{
        //    HMACMD5 hashMD5 = new HMACMD5(Encoding.UTF8.GetBytes(ClaveSecreta));

        //    return hashMD5.ComputeHash(Encoding.UTF8.GetBytes(sCadena));
        //}

        //public static string Obtener(byte[] byCadena)
        //{
        //    return BytesAString(byCadena);  
        //}

        public static string Convertir(string cadena)
        {

            // Convierto la cadena y la clave en arreglos de bytes  
            // para poder usarlas en las funciones de encriptacion  
            byte[] cadenaBytes = Encoding.UTF8.GetBytes(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(ClaveSecreta);

            // Creo un objeto de la clase Rijndael  
            RijndaelManaged rij = new RijndaelManaged();

            // Configuro para que utilice el modo ECB  
            rij.Mode = CipherMode.ECB;

            // Configuro para que use encriptacion de 256 bits.  
            rij.BlockSize = 256;

            // Declaro que si necesitara mas bytes agregue ceros.  
            rij.Padding = PaddingMode.Zeros;

            // Declaro un encriptador que use mi clave secreta y un vector  
            // de inicializacion aleatorio  
            ICryptoTransform encriptador;

            encriptador = rij.CreateEncryptor(claveBytes, rij.IV);

            // Declaro un stream de memoria para que guarde los datos  
            // encriptados a medida que se van calculando  

            MemoryStream memStream = new MemoryStream();

            // Declaro un stream de cifrado para que pueda escribir aqui  
            // la cadena a encriptar. Esta clase utiliza el encriptador  
            // y el stream de memoria para realizar la encriptacion  
            // y para almacenarla  

            CryptoStream cifradoStream;

            cifradoStream = new CryptoStream(memStream, encriptador, CryptoStreamMode.Write);

            // Escribo los bytes a encriptar. A medida que se va escribiendo  
            // se va encriptando la cadena  
            cifradoStream.Write(cadenaBytes, 0, cadenaBytes.Length);


            // Aviso que la encriptación se terminó  
            cifradoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.  
            byte[] cipherTextBytes = memStream.ToArray();

            // Cierro los dos streams creados  
            memStream.Close();
            cifradoStream.Close();

            // Convierto el resultado en base 64 para que sea legible  
            // y devuelvo el resultado  

            return Convert.ToBase64String(cipherTextBytes);

        }

        public static string Obtener(string cadena)
        {
            // Convierto la cadena y la clave en arreglos de bytes  
            // para poder usarlas en las funciones de encriptacion  
            // En este caso la cadena la convierta usando base 64  
            // que es la codificacion usada en el metodo encriptar  

            byte[] cadenaBytes = Convert.FromBase64String(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(ClaveSecreta);

            // Creo un objeto de la clase Rijndael  
            RijndaelManaged rij = new RijndaelManaged();

            // Configuro para que utilice el modo ECB  
            rij.Mode = CipherMode.ECB;

            // Configuro para que use encriptacion de 256 bits.  
            rij.BlockSize = 256;

            // Declaro que si necesitara mas bytes agregue ceros.  
            rij.Padding = PaddingMode.Zeros;

            // Declaro un desencriptador que use mi clave secreta y un vector  
            // de inicializacion aleatorio  
            ICryptoTransform desencriptador;
            desencriptador = rij.CreateDecryptor(claveBytes, rij.IV);

            // Declaro un stream de memoria para que guarde los datos  
            // encriptados  
            MemoryStream memStream = new MemoryStream(cadenaBytes);

            // Declaro un stream de cifrado para que pueda leer de aqui  
            // la cadena a desencriptar. Esta clase utiliza el desencriptador  
            // y el stream de memoria para realizar la desencriptacion  
            CryptoStream cifradoStream = new CryptoStream(memStream, desencriptador, CryptoStreamMode.Read);

            // Declaro un lector para que lea desde el stream de cifrado.  
            // A medida que vaya leyendo se ira desencriptando.  
            StreamReader lectorStream = new StreamReader(cifradoStream);

            // Leo todos los bytes y lo almaceno en una cadena  
            string resultado = lectorStream.ReadToEnd();

            // Cierro los dos streams creados  
            memStream.Close();
            cifradoStream.Close();

            // Devuelvo la cadena  
            return resultado;
        }
    }
}
