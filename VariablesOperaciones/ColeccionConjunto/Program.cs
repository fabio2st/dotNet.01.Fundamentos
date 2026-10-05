namespace ColeccionConjunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> extensiones = new HashSet<string>();

            extensiones.Add("jpg");
            extensiones.Add("png");
            extensiones.Add("jpg");  // ignorado silenciosamente
            extensiones.Add("png");  // ídem

            Console.WriteLine(extensiones.Count);  // 2 — nunca 3 ni 4

            // devuelve true si lo agregó, false si ya existía
            bool nuevo = extensiones.Add("gif");   // true
            nuevo = extensiones.Add("gif");   // false

            HashSet<string> programas = new() { "Word.exe", "Notepad.exe", "Paint.exe" };

            // O(1) — no importa si hay 5 o 5 millones de elementos
            // En List sería O(n) — recorre hasta encontrarlo
            if (programas.Contains("Notepad.exe"))
                Console.WriteLine("Existe");

            HashSet<string> misExtensiones = new() { "jpg", "png", "gif", "bmp" };
            HashSet<string> formatosWeb = new() { "jpg", "png", "webp", "svg" };

            // Diferencia simétrica — los que están en uno pero no en ambos
            misExtensiones.SymmetricExceptWith(formatosWeb);
            // gif, bmp, webp, svg

            HashSet<string> set = new() { "jpg", "png", "gif" };
            HashSet<string> web = new() { "jpg", "png", "webp" };

            set.IntersectWith(web);       // Intersección: los que estan en ambos, set queda: { jpg, png }
            set.UnionWith(web);           // Unión: suma ambos sin repetir, set queda: { jpg, png, webp }
            set.Add("gif");
            set.ExceptWith(web);          // Diferencia: quedan los que no se repiten, set queda: { gif }
            set.SymmetricExceptWith(web); // set queda: { png, gif, gif, webp }

            List<string> extensionesConRepetidos = new()
            {
                "jpg", "png", "jpg", "gif", "png", "bmp", "jpg"
            };

            // Forma más simple de eliminar duplicados
            HashSet<string> sinDuplicados = new(extensionesConRepetidos);
            // { jpg, png, gif, bmp } — orden no garantizado

            // O mantener el orden de primera aparición con List + HashSet juntos
            List<string> unicas = new();
            HashSet<string> vistas = new();
            foreach (var ext in extensionesConRepetidos)
            {
                if (vistas.Add(ext))   // Add devuelve false si ya existía
                    unicas.Add(ext);
            }
            // unicas: [ jpg, png, gif, bmp ] — en orden de aparición
        }
    }
}
