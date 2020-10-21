using System;

namespace RepetirMientrasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo, lecturaActual, cargado = default;
            Console.WriteLine("Medidor");
            Console.Write("Ingrese el máximo: ");
            maximo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Cargado: " + cargado);
                Console.Write("Ingrese una cantidad a cargar: ");
                lecturaActual = Convert.ToInt32(Console.ReadLine());
                cargado += lecturaActual;
            }
            while (cargado < maximo);
            Console.WriteLine("Se ha llenado, sobro: " + (cargado - maximo));
        }
    }
}
