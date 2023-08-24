using System;


namespace CSHARP
{
    internal class Programa
    {
       
        static void Main(string[] args)
        {
            MaquinaParlante Mensajero = new MaquinaParlante();

            Console.WriteLine("Hola Mundo");
            Mensajero.Mensaje();
        }
    }
}
