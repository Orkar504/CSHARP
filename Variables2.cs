using System;


namespace CSHARP
{
    internal class Variables2
    {
        public string nombre = "<<tu nombre>>";

        private int edad =  21;

        public char seccion = 'a';

        public double nota = 90.9;

        public bool estudiante = true;
        public void variables2()
        {
            string clase = "Programación";
            double extra = 2.1;
            double total = 0;

            Console.Write("¡Hola! soy ");
            Console.WriteLine(nombre);
            Console.Write("Tengo los siguientes años: ");
            Console.WriteLine(edad);

            Console.Write("Soy de la seccion");
            Console.WriteLine(seccion);
            Console.Write("De la clase de:");
            Console.WriteLine(clase);
            Console.Write("Mi nota es de");
            Console.WriteLine(nota);
            Console.Write("Pero con el punto extra que me dio el profe, ahora tengo");

            total = nota + extra; // sumando nota con extra para guardarlo en una variable local llamada total
            nota = total; //Asignandole el valor de total a nota

            Console.WriteLine(nota);

            

        }
    }
}
