using System;

namespace SiEntoncesVb
{
    static class Program
    {
        public static void Main(string[] args)
        {
            short a;
            Console.Write("Ingrese un valor: ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Es positivo");

            if (a > 0)
                Console.WriteLine("Es positivo");
            else
                Console.WriteLine("No Es positivo");

            if (a > 0)
                Console.WriteLine("Es positivo");
            else if (a < 0)
                Console.WriteLine("Es negativo");
            else
                Console.WriteLine("Es cero");

            if (a > 0)
                Console.WriteLine("Es positivo");
            else
            {
                Console.WriteLine("No Es positivo");
                if(a < 0)
                    Console.WriteLine("Es negativo");
                else
                    Console.WriteLine("Es cero");
            }

            short b = Convert.ToInt16(Console.ReadLine());
            short c = Convert.ToInt16(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("A es mayor que b y c");

            if (a > b || a > c)
                Console.WriteLine("A es mayor que b o c");

            if ((a > c || a > b) && b > c)
                Console.WriteLine("resultado esperado");
        }
    }
}