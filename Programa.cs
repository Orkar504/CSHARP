using System;


namespace CSHARP
{
    internal class Programa
    {
       
        static void HolaMundo()
        {
            MaquinaParlante Mensajero = new MaquinaParlante();

            Console.WriteLine("Hola Mundo");
            Mensajero.Mensaje();
        }
    }
}
