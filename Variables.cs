using System;
using System.Security.Cryptography.X509Certificates;

namespace CSHARP
{
    internal class Variables
    {
        /* Variables globales de la clase*/
        public int entero = 0;
        public double flotante = 1.23;
        public string cadena = "cadena de texto";
        public char caracter = 'a';
        public bool booleano = true;
        public void variables()
        {
            Console.Write("Números enteros en c sharp con int: ");
            Console.WriteLine(entero);
            Console.Write("Números con sus decimales en c sharp con double: ");
            Console.WriteLine(flotante);
            Console.Write("Cadena de caracteres con string : ");
            Console.WriteLine(cadena);
            Console.Write("un solo character con char : ");
            Console.WriteLine(caracter);
            Console.Write("Los booleanos para saber si algo es verdadero o falso con bool : ");
            Console.WriteLine(booleano);

            /* Variables locales */

            int entero2 = 0;
         double flotante2 = 0.00;
         string cadena2 = "cadena de texto";
         char caracter2 = 'a';
         bool booleano2 = true;


    }

    
    }
}
