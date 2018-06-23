using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("¡Hola usuario!");
            Console.WriteLine("Para continuar golpea fuerte el teclado");
            Console.ReadKey();

            Console.WriteLine("Por favor introduce un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduce un numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La media de los números es: " + ObtenerMedia(a, b));
            Console.WriteLine("El máximo de los números es: " + ObtenerMaximo(a, b));
            Console.WriteLine("El mínimo de los números es: " + ObtenerMinimo(a, b));
            Console.ReadKey();

        }
        static int ObtenerMedia(int a, int b)
        {
            return (a + b) / 2;
        }
        static int ObtenerMaximo(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static int ObtenerMinimo(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }
    }
}
