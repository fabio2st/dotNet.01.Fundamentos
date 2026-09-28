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

            foreach (var item in lista)
                Console.WriteLine(item);

            nodo = lista.Last;
            while (nodo != null)
            {
                Console.WriteLine(nodo.Value);
                nodo = nodo.Previous;
            }

            // ── Tupla (int Id, string Name)
            var localidades = new LinkedList<(int Id, string Name)>();

            AgregarLocalidad(localidades, (4, "Santa Ana"));
            AgregarLocalidad(localidades, (7, "Corpus"));
            AgregarLocalidad(localidades, (9, "Hipolito Irigoyen"));
            AgregarLocalidad(localidades, (1, "Posadas"));
            AgregarLocalidad(localidades, (5, "San Ignacio"));

            foreach (var (id, name) in localidades)
                Console.WriteLine($"{id} - {name}");
        }

        private static void AgregarLocalidad(
            LinkedList<(int Id, string Name)> localidades,
            (int Id, string Name) localidad)
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
}