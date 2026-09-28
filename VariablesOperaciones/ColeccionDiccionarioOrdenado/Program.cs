namespace ColeccionDiccionarioOrdenado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SortedDictionary!");
            SortedDictionary<string, string> fileTypes = new();
            fileTypes["bmp"] = "Paint.exe";
            fileTypes["txt"] = "Notepad.exe";
            fileTypes["rtf"] = "Wordpad.exe";
            fileTypes["docx"] = "Word.exe";

            // Las claves siempre se iteran en orden alfabético ascendente
            // a diferencia de Dictionary que no garantiza orden
            var extension = "rtf";
            Console.WriteLine("El programa para el archivo {0} es {1}", extension, fileTypes[extension]);

            BuscarPrograma(fileTypes, extension);
            BuscarPrograma(fileTypes, "none");

            Console.WriteLine("Cantidad de elementos: {0}", fileTypes.Count);

            Console.WriteLine("Mostrar todas las claves (ordenadas alfabéticamente)");
            foreach (var key in fileTypes.Keys)
                Console.WriteLine($"{key}");

            Console.WriteLine("Mostrar todos los valores");
            foreach (var value in fileTypes.Values)
                Console.WriteLine($"{value}");

            fileTypes.Add("pdf", "Foxit Reader");

            isValidKey(fileTypes, extension);
            isValidKey(fileTypes, "none");

            Console.WriteLine("Mostrar todos los pares clave-valor (ordenados por clave)");
            foreach (var kvp in fileTypes)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
                //kvp.Key = "Nueva clave"; // No se puede modificar la clave
                //kvp.Value = "Nuevo valor"; // No se puede modificar el valor asociado a la clave
            }

            // Orden inverso mediante comparador personalizado
            Console.WriteLine("Mostrar pares en orden descendente");
            SortedDictionary<string, string> fileTypesDesc = new(
                fileTypes,
                Comparer<string>.Create((a, b) => b.CompareTo(a))
            );
            foreach (var kvp in fileTypesDesc)
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");

            // SortedDictionary no admite clave null — igual que Dictionary
            // fileTypes[null] = "nada"; // ArgumentNullException en tiempo de ejecución
        }

        private static void isValidKey(SortedDictionary<string, string> fileTypes, string extension)
        {
            Console.WriteLine("Validar si existe una clave");
            if (fileTypes.ContainsKey(extension))
                Console.WriteLine($"Existe la clave {extension}");
            else
                Console.WriteLine($"No existe la clave {extension}");
        }

        private static void BuscarPrograma(SortedDictionary<string, string> fileTypes, string extension)
        {
            // Verificación segura — igual que en Dictionary
            if (fileTypes.TryGetValue(extension, out string? programa))
                Console.WriteLine(programa);
            else
                Console.WriteLine("No existe");
        }
    }
}
