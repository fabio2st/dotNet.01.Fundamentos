namespace ColeccionLIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LIFO!");
            Stack<string> pila = new();
            pila.Push("Primer elemento");
            pila.Push("Segundo elemento");
            pila.Push("Tercer elemento");

            Console.WriteLine("Primer elemento: " + pila.Peek());

            while (pila.Count > 0)
            {
                var item = pila.Pop();
                Console.WriteLine(item);
            }
        }
    }
}
