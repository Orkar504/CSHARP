using System;


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
        private bool esPrivado = true;
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

            int entero2 = 0; // Para números enteros
            double flotante2 = 1.23; //Para número con decimales
            string cadena2 = "cadena de texto"; //Para cadenas de texto
            char caracter2 = 'a'; // Para un solo caracter
            bool booleano2 = true; // Para los booleanos


        }

    
    }
}
