using System.Collections;

namespace ColeccionNoGenericaCs
{
	internal class Program
	{
		static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add(2);
            lista.Add("3");

            MostrarSuma(lista);

            // kabooom
            //lista.Add("Cuatro");
            //MostrarSuma(lista);
        }

        private static void MostrarSuma(ArrayList lista)
        {
            int Sum = 0;
            Console.WriteLine("Sumando");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
                Sum += Convert.ToInt32(item);
            }

            Console.WriteLine($"Suma es {Sum}");
        }
    }
}
