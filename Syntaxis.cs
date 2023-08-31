using System; //Para utilizar las clases relacionadas al sistema, de ahi su nombre system


//Las lineas vacias las ignora c#, pero es una buena práctica dejar una división para mejor legibilidad

// se utilizan las // para hacer un comentario
// Se utiliza /**/ para hacer un bloque de comentario

namespace CSHARP //namespace es utilizado para organizar el código, es el contenerdor para otras clases y otros namespaces
{ // Las {} son indicador de donde empieza y termina un bloque de código
    public class Syntaxis //La palabra reservada class es un contenedor de datos  métodos, esta permite la funcionalidad de tu programa
    {
        public void sintaxis() //Este es un método, permite la funcionalidad del código
        {

            /*static void Main(string[] args) // Main es donde se ejecuta cualquier código que este dentro de este bloque
            {

            } */

            Console.WriteLine("Explicando la sintaxis de c#"); // Console es una clase de System,  
            Console.WriteLine("Explicando el ;"); //Toda linea de código o sentencia siempre debe terminar con ;


        }
    }


}
