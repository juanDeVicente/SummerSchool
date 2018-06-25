using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo;
            int divisor;
            int cociente;
            int resto;

            Console.Write("Dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            divisor = int.Parse(Console.ReadLine());
            cociente = dividendo / divisor;
            resto = dividendo % divisor;

            if (resto == 0)
                Console.WriteLine("La división es exacta");
            else
                Console.WriteLine("La división no es exacta");
            Console.WriteLine("Cociente: " + cociente);
            Console.WriteLine("Resto: " + resto);
            Console.ReadKey();
        }
    }
}
