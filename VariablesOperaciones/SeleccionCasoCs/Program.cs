
using System;

namespace SeleccionCaso
{
    class Program
    {
        private const short minimo = -10;
        private const ushort maximo = 10;

        static void Main(string[] args)
        {
            short valor;
            Console.Write("Ingrese un valor entre {0} y {1}: ", minimo, maximo);
            valor = Convert.ToInt16(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    {
                        Console.WriteLine("Es uno");
                        throw new Exception();
                    }

                case 2:
                    {
                        Console.WriteLine("Es dos");
                        break;
                    }

                case 3:
                case 5:
                    {
                        Console.WriteLine("Es tres o cinco");
                        break;
                    }

                case var @case when 6 <= @case && @case <= 8:
                    {
                        Console.WriteLine("Es de seis a ocho");
                        break;
                    }

                case var case1 when case1 < 0:
                    {
                        Console.WriteLine("Es negativo");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Es otro numero: " + valor);
                        break;
                    }
            }
        }
    }
}