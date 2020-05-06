using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort contador = 1;
            Console.WriteLine(contador);
            contador += 1;
            Console.WriteLine(contador);
            contador ++;
            Console.WriteLine(contador);
            contador++;
            Console.WriteLine(contador);
            ++contador;
            Console.WriteLine(contador);//uint acumulador = 0;
            //Console.WriteLine(acumulador);
            //acumulador += Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine(acumulador);
            //acumulador += Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine(acumulador);
            uint a = 8;
            a *= a;
            Console.WriteLine(a);
            uint b = 11;
            Console.WriteLine(a/b);
            //Console.WriteLine(a\b);
            Console.WriteLine(a % b);
            Console.WriteLine(-1 * 2 % 3 + 4);
        }
    }
}
