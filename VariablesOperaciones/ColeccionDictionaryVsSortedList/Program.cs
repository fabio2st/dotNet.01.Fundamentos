namespace ColeccionDictionaryVsSortedList
{
	using System;
	using System.Collections.Generic;
	class Program
	{
		static void Main()
		{
			// Dictionary: más rápido pero sin orden
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict[3] = "Tres";
			dict[1] = "Uno";
			dict[4] = "Cuatro";
			dict[2] = "Dos";

			Console.WriteLine("Dictionary:");
			foreach (var kvp in dict)
				Console.WriteLine($"{kvp.Key} = {kvp.Value}");
			// El orden puede variar

			// SortedList: mantiene las claves ordenadas
			SortedList<int, string> sorted = new SortedList<int, string>();
			sorted[3] = "Tres";
			sorted[1] = "Uno";
			sorted[4] = "Cuatro";
			sorted[2] = "Dos";

			Console.WriteLine("\nSortedList:");
			foreach (var kvp in sorted)
				Console.WriteLine($"{kvp.Key} = {kvp.Value}");
			// Siempre imprime en orden 1, 2, 3
		}
	}
}
