using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; //Este tipo de variable es de tipo entero, sin decimales
            float b = 3.14f; //Este tipo de variable es decimal con precisión de coma flotante de 32 bits, con decimales y más pequeño que el double
            double c = 12348972364.2378d; //Este tipo de variable es decimal con precisión de coma flotante de 64 bits, con decimales.
            char letra = 'a'; //Este tipo de variable es un caracter de la tabla ASCII.
            string texto = "Esto es un texto"; //Este tipo de variable es un texto.
            Console.WriteLine(a + " es de tipo entero!");
            Console.WriteLine(b + " es de tipo float!");
            Console.WriteLine(c + " es de tipo double!");
            Console.WriteLine(letra + " es de tipo char!");
            Console.WriteLine(texto + "es de tipo string!");
            Console.ReadKey();
        }
    }
}
