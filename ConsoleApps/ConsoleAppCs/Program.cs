using System;

namespace ConsoleAppCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, presiona una tecla para operar");
            Console.ReadKey();
                // declaración de variables
            string nombre, apellido;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " " + apellido);
         }
    }
}
