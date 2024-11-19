
using System.Collections;

namespace ColeccionGenerica
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Colleciones!");
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
			foreach (var item in lista)
			{
				Sum += Convert.ToInt32(item);
			}

			Console.WriteLine($"Suma es {Sum}");
			Console.WriteLine($"Suma es {lista.Sum()}");

		}

		private static void Paises()
		{
			List<string> paises = new List<string>();
			paises.Add("Argentina");
			paises.Add("Brasil");
			paises.Add("Uruguay");
			paises.Add("Paraguay");
			paises.Add("Chile");

			// iterar con índice
			for (int index = 0; index < paises.Count; index++)
			{
				Console.WriteLine(paises[index]);
			}

			// cambiar un valor
			paises[4] = "Bolivia";

			string[] otrosPaises = { "Venezuela", "Ecuador", "Colombia" };
			paises.AddRange(otrosPaises);

			Console.WriteLine(paises.Contains("Chile"));
			Console.WriteLine(paises.Contains("Bolivia"));

			paises.Insert(4, "Chile");

			paises.Sort();
			paises.Reverse();

			Console.WriteLine(paises.IndexOf("Brasil"));
			Console.WriteLine(paises.IndexOf("None"));

			foreach (string s in paises.Where(x => x.Contains('r')))
				{ Console.WriteLine(s); }

			paises.Remove("Venezuela");
			paises.RemoveAt(4);
			paises.Clear();
		}
	}
}
