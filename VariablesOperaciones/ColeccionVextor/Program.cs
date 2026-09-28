
using System.Collections;

namespace ColeccionVector
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Array Collection!");
			Suma();
			Paises();
		}

		private static void Suma()
		{
			List<int> lista = new ();
			lista.Add(1);
			lista.Add(2);
			lista.Add(Convert.ToInt32("3"));

			int Sum = 0;
            Console.WriteLine("Sumando");
			foreach (var item in lista)
			{
                Console.WriteLine(item);
				Sum += item;
			}

			Console.WriteLine($"Suma por iteración {Sum}");
			Console.WriteLine($"Cantidad de elementos {lista.Count}");

		}

		private static void Paises()
        {
            // Declaración ArrayList
            List<string> paises = new List<string>();
            paises.Add("Argentina");
            paises.Add("Brasil");
            paises.Add("Uruguay");
            paises.Add("Paraguay");
            paises.Add("Chile");

            // iterar con índice
            for (int index = 0; index < paises.Count; index++)
            {
                Console.WriteLine(paises.ElementAt(index));
                Console.WriteLine(paises[index]);
            }

            // cambiar un valor
            Console.WriteLine("Cambiar un país");
            paises[4] = "Bolivia";
            Mostrar(paises);

            // asignación de un array
            Console.WriteLine("Agregando varios países");
            string[] otrosPaises = { "Venezuela", "Ecuador", "Colombia" };
            paises.AddRange(otrosPaises);
            Mostrar(paises);

            var pais = "Chile";
            Console.WriteLine("Busando {0}: {1}", pais, paises.Contains(pais));
            pais = "Bolivia";
            Console.WriteLine("Busando {0}: {1}", pais, paises.Contains(pais));

            Console.WriteLine("Insertar un país");
            paises.Insert(4, "Chile");
            Mostrar(paises);

            Console.WriteLine("Ordenar");
            paises.Sort();
            Mostrar(paises);

            Console.WriteLine("Invertir");
            paises.Reverse();
            Mostrar(paises);

            Console.WriteLine("Mostrar índice de " + pais);
            Console.WriteLine(paises.IndexOf(pais));
            Console.WriteLine(paises.IndexOf("None"));

            Console.WriteLine("Remover un país");
            paises.Remove("Venezuela");
            Mostrar(paises);

            paises.RemoveAt(4);
            Mostrar(paises);

            Console.WriteLine("Borrar todos");
            paises.Clear();
            Mostrar(paises);
        }

        private static void Mostrar(List<string> paises)
        {
            foreach (string pais in paises)
                Console.WriteLine(pais);
            Console.WriteLine("----------------------");
        }
    }
}
