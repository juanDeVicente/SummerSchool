using System;

namespace FormasGemoetricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a formas gemoetricas, por favor introduce una forma:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Rectángulo");
            string option = Console.ReadLine();

            if (option == "1") //Cuadrado
            {
                Console.WriteLine("Introduce la longitud del lado");
                Cuadrado(double.Parse(Console.ReadLine()));
            }
            else if (option == "2") //Circulo
            {
                Console.WriteLine("Introduce la longitud del radio");
                Circulo(double.Parse(Console.ReadLine()));
            }
            else if (option == "3") //Rectangulo
            {
                Console.WriteLine("Introduce la longitud de la base");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la longitud de la altura");
                double a = double.Parse(Console.ReadLine());
                Rectangulo(a, b);
            }
            else //Algo no valido
            {
                Console.WriteLine("No has introducido algo válido");
            }
            Console.ReadKey();
        }
        static void Circulo(double radio)
        {
            double perimetro = 2 * Math.PI * radio;
            double area = Math.PI * radio * radio;
            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine("Area: " + area);
        }
        static void Cuadrado(double lado)
        {
            double perimetro = 4 * lado;
            double area = lado * lado;
            double diagonal = lado * Math.Sqrt(2);
            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Diagonal: " + diagonal);
        }
        static void Rectangulo(double a, double b)
        {
            double perimetro = 2 * a + 2 * b;
            double area = a * b;
            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine("Area: " + area);
        }
    }
}
