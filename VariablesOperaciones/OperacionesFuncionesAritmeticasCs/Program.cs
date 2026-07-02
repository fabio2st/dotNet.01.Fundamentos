using System;

namespace OperacionesFuncionesAritmeticasCs
{
    class Program
    {
        const int iva = 21;
        static void Main(string[] args)
        {
			// contador o incrementador
			 ushort contador = 0;
            Console.WriteLine(++contador);
            Console.WriteLine(++contador);
            Console.WriteLine(++contador);
            // acumulador
            uint acumulador = 0;
            acumulador += 20;
            Console.WriteLine(acumulador);
            acumulador += 10;
            Console.WriteLine(acumulador);
            acumulador += 25;
            Console.WriteLine(acumulador);
            // división
            Console.WriteLine(25 / 10);
            // resto
            Console.WriteLine(25 % 10);
            // exponenciacion
            ushort r = 5;

            r *= r;
            Console.WriteLine("Impuestos con constante: " + 1000 * iva / 100);

			Console.WriteLine(r);
            Console.WriteLine(Math.Truncate( 25.0 / 10));
            Console.WriteLine(Math.Pow(5,5));
			Console.WriteLine(Math.Abs(-r));
			Console.WriteLine(Math.Abs(r));
            //conversion
                int a = 2147483647;
            long b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            // casting
            double c = 1234.5;
            int d;
            d = (int)c;
            Console.WriteLine(d);
            a = 4;
            b = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(-a++);
            Console.WriteLine(-++a);
            Console.WriteLine(b + a / b);
            Console.WriteLine((float)(b + a) / b);
            Console.WriteLine(b * a / b);
            Console.WriteLine((float)a / b * b);

        }
    }
}
