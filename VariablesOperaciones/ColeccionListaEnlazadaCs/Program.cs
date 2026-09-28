namespace ColeccionListaEnlazadaCs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Linked List!");

			var lista = new LinkedList<string>();
			lista.AddLast("Garupa");
			lista.AddLast("Candelaria");
			lista.AddLast("Jardín America");
			lista.AddFirst("Posadas");
			var nodo = lista.Find("Candelaria");
			lista.AddAfter(nodo, "Santa Ana");
			nodo = lista.Find("Jardín America");
			lista.AddBefore(nodo, "San Ignacio");
			//lista.Remove()
			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}

			nodo = lista.Last;
			while (nodo != null)
			{
				Console.WriteLine(nodo.Value);
				nodo = nodo.Previous;
			}
			Console.ReadKey();

			var localidades = new LinkedList<Localidad>();
			Localidad localidad;
			localidad = new Localidad() { Id = 4, Name = "Santa Ana" };
			AgregarLocalidad(localidades, localidad);
			localidad = new Localidad() { Id = 7, Name = "Corpus" };
			AgregarLocalidad(localidades, localidad);
			localidad = new Localidad() { Id = 9, Name = "Hipolito Irigoyen" };
			AgregarLocalidad(localidades, localidad);
			localidad = new Localidad() { Id = 1, Name = "Posadas" };
			AgregarLocalidad(localidades, localidad);
			localidad = new Localidad() { Id = 5, Name = "San Ignacio" };
			AgregarLocalidad(localidades, localidad);
			foreach (var item in localidades)
				Console.WriteLine(item);
		}

		private static void AgregarLocalidad(LinkedList<Localidad> localidades, Localidad localidad)
		{
			if (localidades.Count == 0)
			{
				localidades.AddFirst(localidad);
				return;
			}
			foreach (var item in localidades)
			{
				if (item.Id > localidad.Id)
				{
					var itemNodo = localidades.Find(item);
					localidades.AddBefore(itemNodo, localidad);
					return;
				}
			}
			localidades.AddLast(localidad);
		}
	}
	class Localidad
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public override string ToString()
		{
			return Id + " - " + Name;
		}
	}
}
