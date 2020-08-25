using System;
using Microsoft.VisualBasic.CompilerServices;

namespace SiEntoncesVb
{
    static class Program
    {
        public static void Main(string[] args)
        {
            short a;
            Console.WriteLine("Ingrese un valor");
            a = Conversions.ToShort(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Es positivo");

            if (a > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("No Es positivo");
            }

            if (a > 0)
                Console.WriteLine("Es positivo");
            else if (a < 0)
                Console.WriteLine("Es negativo");
            else
                Console.WriteLine("Es cero");
        }
    }
}