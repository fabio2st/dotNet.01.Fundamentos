using System;

namespace IteracionParaCs
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // de 0 a 3 en paso 1 
            for (int x = 0; x <= 3; x++)
            {
                Console.WriteLine("x: {0}", x);
            }
            // de 0 a 10 en paso 3 
            for (int x = 0; x <= 10; x += 3)
                Console.WriteLine("x: {0}", x);
            // de 0 a 10 en paso -3 
            for (int x = 0; x >= 10; x -= 3)
                Console.WriteLine("x: {0}", x);
            // de 10 a 0 en paso -3 
            for (int x = 10; x >= 0; x -= 3)
                Console.WriteLine("x: {0}", x);

            // iterando un numero curioso 142857 hasta que el resultado sea menor a 999999
            // la condición de parada no es necesariamente el número de iteraciones
            int y = 0;
            const int curiusNumber = 142857;
            for (int x = 1; y < 999999; x++)
            {
                y =  curiusNumber * x;
                Console.WriteLine("{0} x {1} = {2}", x, curiusNumber, y);
            }
    }
}
}