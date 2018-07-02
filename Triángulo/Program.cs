using System;

namespace Triángulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.Write("Introduce un número: ");
            while(!int.TryParse(Console.ReadLine(), out altura) || altura < 1)
            {
                Console.Clear();
                Console.Write("Introduce un número: ");
            }
            int numeroEspacios = altura - 1;
            int asteriscos = 1;
            for(int i = 0; i < altura; i++)
            {
                Console.Write(new string(' ', numeroEspacios));
                Console.WriteLine(new string('*', asteriscos));
                numeroEspacios--;
                asteriscos += 2;
            }
            Console.ReadKey();
        }
    }
}
