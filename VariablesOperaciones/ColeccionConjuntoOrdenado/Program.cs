namespace ColeccionConjuntoOrdenado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SortedSet!");

            // ── Creación y carga ─────────────────────────────────────
            // Las extensiones se insertan en orden aleatorio
            // pero SortedSet las mantiene siempre ordenadas
            SortedSet<string> extensiones = new SortedSet<string>();

            extensiones.Add("bmp");
            extensiones.Add("txt");
            extensiones.Add("rtf");
            extensiones.Add("docx");
            extensiones.Add("pdf");

            // ── Iteración — siempre ordenada ─────────────────────────
            Console.WriteLine("\nExtensiones ordenadas:");
            foreach (var ext in extensiones)
                Console.WriteLine($"  {ext}");

            // Intento de duplicado — ignorado silenciosamente
            bool agregado = extensiones.Add("pdf");
            Console.WriteLine($"¿'pdf' fue agregado? {agregado}");  // false

            // ── Min, Max ─────────────────────────────────────────────
            Console.WriteLine($"\nPrimera (min): {extensiones.Min}");
            Console.WriteLine($"Última  (max): {extensiones.Max}");

            // ── Búsqueda y pertenencia ───────────────────────────────
            Console.WriteLine($"\n¿Existe 'rtf'?  {extensiones.Contains("rtf")}");
            Console.WriteLine($"¿Existe 'xlsx'? {extensiones.Contains("xlsx")}");

            // ── Rango con GetViewBetween ──────────────────────────────
            // Devuelve un subconjunto entre dos valores inclusive
            Console.WriteLine("\nExtensiones entre 'b' y 'r' (GetViewBetween):");
            var rango = extensiones.GetViewBetween("b", "r");
            foreach (var ext in rango)
                Console.WriteLine($"  {ext}");

            // ── Orden inverso ────────────────────────────────────────
            Console.WriteLine("\nExtensiones en orden descendente:");
            foreach (var ext in extensiones.Reverse())
                Console.WriteLine($"  {ext}");

            // ── Operaciones de conjuntos ─────────────────────────────
            SortedSet<string> formatosWeb = new SortedSet<string>
                { "jpg", "png", "webp", "pdf", "txt" };

            Console.WriteLine("\nFormatos web:");
            foreach (var ext in formatosWeb)
                Console.WriteLine($"  {ext}");

            // Intersección — en ambos conjuntos, resultado ordenado
            var enComun = new SortedSet<string>(extensiones);
            enComun.IntersectWith(formatosWeb);
            Console.WriteLine("\nIntersección (en ambos):");
            foreach (var ext in enComun)
                Console.WriteLine($"  {ext}");

            // Unión — todos sin repetir, resultado ordenado
            var todos = new SortedSet<string>(extensiones);
            todos.UnionWith(formatosWeb);
            Console.WriteLine("\nUnión (todos sin repetir):");
            foreach (var ext in todos)
                Console.WriteLine($"  {ext}");

            // Diferencia — los míos que no están en web
            var soloMios = new SortedSet<string>(extensiones);
            soloMios.ExceptWith(formatosWeb);
            Console.WriteLine("\nDiferencia (solo en extensiones):");
            foreach (var ext in soloMios)
                Console.WriteLine($"  {ext}");

            // ── Comparaciones de conjuntos ───────────────────────────
            SortedSet<string> subconjunto = new SortedSet<string> { "pdf", "txt" };
            Console.WriteLine($"\n¿{{pdf, txt}} es subconjunto de extensiones? " +
                              $"{subconjunto.IsSubsetOf(extensiones)}");
            Console.WriteLine($"¿extensiones es superconjunto de {{pdf, txt}}? " +
                              $"{extensiones.IsSupersetOf(subconjunto)}");
            Console.WriteLine($"¿Se solapan extensiones y formatosWeb? " +
                              $"{extensiones.Overlaps(formatosWeb)}");

            // ── Eliminación ──────────────────────────────────────────
            extensiones.Remove("bmp");
            Console.WriteLine($"\nTras eliminar 'bmp': {string.Join(", ", extensiones)}");

            Console.WriteLine($"\nCantidad final: {extensiones.Count}");
            Console.ReadKey();
        }
    }
}