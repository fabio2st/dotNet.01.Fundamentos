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

			int Sum = 0;
			foreach (var item in lista)
			{
				Sum += Convert.ToInt32(item);
			}

			Console.WriteLine($"Suma es {Sum}");
		}
	}
}
