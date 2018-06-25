using System;

namespace Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un año");
            int anio = int.Parse(Console.ReadLine());
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
                Console.WriteLine("Es bisiesto");
            else
                Console.WriteLine("No es bisiesto");
            Console.ReadKey();
        }
    }
}
