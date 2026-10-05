namespace ColeccionSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SortedList!");
            SortedList<string, string> fileTypes = new SortedList<string, string>(capacity: 10);

            fileTypes["bmp"] = "Paint.exe";
            fileTypes["txt"] = "Notepad.exe";
            fileTypes["rtf"] = "Wordpad.exe";
            fileTypes["docx"] = "Word.exe";

            // A diferencia de Dictionary, las claves siempre
            // se muestran en orden alfabético ascendente
            Console.WriteLine("\nMostrar todas las claves (ordenadas alfabéticamente)");
            foreach (var key in fileTypes.Keys)
                Console.WriteLine($"{key}");

            Console.WriteLine("Mostrar todos los valores");
            foreach (var value in fileTypes.Values)
                 Console.WriteLine($"{value}");

            var extension = "rtf";
            Console.WriteLine("El programa para el archivo {0} es {1}", extension, fileTypes[extension]);

            BuscarPrograma(fileTypes, extension);
            BuscarPrograma(fileTypes, "none");

            Console.WriteLine("Cantidad de elementos: {0}", fileTypes.Count);

            // ── Acceso por índice posicional ─────────────────────
            // Esta capacidad NO existe en Dictionary ni SortedDictionary
            Console.WriteLine("\n── Acceso por posición ──");
            Console.WriteLine($"Primera extensión: {fileTypes.Keys[0]}");
            Console.WriteLine($"Última extensión:  {fileTypes.Keys[fileTypes.Count - 1]}");
            Console.WriteLine($"Programa en pos 2: {fileTypes.Values[2]}");

            // ── Obtener índice de una clave o valor ───────────────
            int indice = fileTypes.IndexOfKey("rtf");
            Console.WriteLine($"\nLa extensión 'rtf' está en la posición: {indice}");

            int indiceValor = fileTypes.IndexOfValue("Notepad.exe");
            Console.WriteLine($"'Notepad.exe' está en la posición: {indiceValor}");


            fileTypes.Add("pdf", "Foxit Reader");

            isValidKey(fileTypes, extension);
            isValidKey(fileTypes, "none");

            Console.WriteLine("\nMostrar todos los pares clave-valor (ordenados por clave)");
            foreach (var kvp in fileTypes)
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");

            Console.WriteLine("\nMostrar todos con su indice");
            for (int i = 0; i < fileTypes.Count; i++)
                Console.WriteLine($"[{i}] Clave: {fileTypes.Keys[i]}, Valor: {fileTypes.Values[i]}");

            // ── Capacidad y memoria ───────────────────────────────
            Console.WriteLine($"\nCapacidad actual:   {fileTypes.Capacity}");
            Console.WriteLine($"Elementos actuales: {fileTypes.Count}");
            fileTypes.TrimExcess();
            Console.WriteLine($"Capacidad tras TrimExcess: {fileTypes.Capacity}");

            // ── Orden descendente con comparador personalizado ────
            Console.WriteLine("\nMostrar pares en orden descendente");
            SortedList<string, string> fileTypesDesc = new SortedList<string, string>(
                fileTypes,
                Comparer<string>.Create((a, b) => b.CompareTo(a))
            );
            for (int i = 0; i < fileTypesDesc.Count; i++)
                Console.WriteLine($"[{i}] Clave: {fileTypesDesc.Keys[i]}, Valor: {fileTypesDesc.Values[i]}");

            // SortedList tampoco admite clave null
            // fileTypes[null] = "nada"; // ArgumentNullException en tiempo de ejecución
        }

        private static void isValidKey(SortedList<string, string> fileTypes, string extension)
        {
            Console.WriteLine("Validar si existe una clave");
            if (fileTypes.ContainsKey(extension))
                Console.WriteLine($"Existe la clave {extension}");
            else
                Console.WriteLine($"No existe la clave {extension}");
        }

        private static void BuscarPrograma(SortedList<string, string> fileTypes, string extension)
        {
            if (fileTypes.TryGetValue(extension, out string? programa))
                Console.WriteLine(programa);
            else
                Console.WriteLine("No existe");
        }
    }
}
