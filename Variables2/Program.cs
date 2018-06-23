using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = Console.ReadLine(); //En la variable almacenamos el valor del texto que el usuario introduce por la pantalla

            Console.WriteLine("¡Hola, " + nombre + "!"); //Le pedimos que imprima por pantalla "¡Hola, ", le concatenamos lo que esté almacenado en la variable nombre y le concatenamos "!"
            Console.WriteLine("¡Adios, " + nombre + "!"); //Le pedimos que imprima por pantalla "¡Adios, ", le concatenamos lo que esté almacenado en la variable nombre y le concatenamos "!"
        }
    }
}
