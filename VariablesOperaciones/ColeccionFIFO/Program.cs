namespace ColeccionFIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Queue!");
            Queue<string> cola = new ();
            cola.Enqueue("Primer elemento");
            cola.Enqueue("Segundo elemento");
            cola.Enqueue("Tercer elemento");

            Console.WriteLine("Primer elemento: " + cola.Peek());

            Console.WriteLine("Elementos en la cola:");
            while (cola.Count > 0)
            {
                var item = cola.Dequeue();
                Console.WriteLine(item);
            }
        }
    }
}
