using System;

namespace MediaRaul
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaExamen1;
            double notaExamen2;
            double notaPracticas;
            double notaActitud;
            double notaFinal = 5.0;
            bool datosBien = true;

            Console.WriteLine("Dime tu nota en el primer examen: ");
            notaExamen1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime tu nota en el segundo examen: ");
            notaExamen2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime tu nota en las prácticas: ");
            notaPracticas = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime tu nota en la actitud en clase: ");
            notaActitud = double.Parse(Console.ReadLine());
            if(notaExamen1 < 0 || notaExamen1 > 10)
            {
                Console.WriteLine("La nota del examen 1 ha sido mal introducida");
                datosBien = false;
            }
            if (notaExamen2 < 0 || notaExamen2 > 10)
            {
                Console.WriteLine("La nota del examen 2 ha sido mal introducida");
                datosBien = false;
            }
            if (notaPracticas < 0 || notaPracticas > 10)
            {
                Console.WriteLine("La nota de las practicas ha sido mal introducida");
                datosBien = false;
            }
            if (notaActitud < 0 || notaActitud > 10)
            {
                Console.WriteLine("La nota de la actitud en clase ha sido mal introducida");
                datosBien = false;
            }
            if(datosBien)
            {
                double notaExamenes = (notaFinal - (0.4 * notaPracticas) - (0.2 * notaActitud))/0.4;

                if (notaExamenes < 4.0)
                    notaExamenes = 4.0;
                double notaExamenFinal = (3 * notaExamenes) - notaExamen1 - notaExamen2;
                if (notaExamenFinal > 10)
                    Console.WriteLine("No puedes aprobar ya que en el examen final necesitarías sacar un " + notaExamenFinal);
                else if (notaExamenFinal == 10)
                    Console.WriteLine("Para aprobar necesitas sacar en el examen final un " + notaExamenFinal);
                else
                {
                    if (notaExamenFinal < 3.0)
                        notaExamenFinal = 3.0f;
                    Console.WriteLine("Para aprobar necesitas sacar en el examen final un " + notaExamenFinal + " o más");
                }
                

            }
            Console.ReadKey();
        }
    }
}
