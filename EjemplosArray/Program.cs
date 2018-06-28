using System;

namespace EjemplosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            Console.Write("Introduce un número:");
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n) && n < 0)
            {
                Console.Clear();
                Console.Write("Introduce un número: ");
            }
            array = FillRandom(n);
            Console.WriteLine(Join(array));
            Console.ReadKey();
        }
        static int[] FillRandom(int n)
        {
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(10);
            return array;
        }
        static int CumSum(int[] array)
        {
            int cumSum = 0;
            foreach (int element in array)
                cumSum += element;
            return cumSum;
        }
        static double Average(int[] array)
        {
            return CumSum(array) * 1.0 / array.Length;
        }
        static string Join(int[] array)
        {
            if (array.Length == 1)
                return "[" + array[0] + "]";
            string join = "[" + array[0] + ", ";
            for (int i = 1; i < array.Length - 1; i++)
                join += array[i] + ", ";
            if(array.Length > 1)
                join += array[array.Length - 1] + "]";

            return join;
        }
    }
}
