using System;

namespace ProcedimientosCs
{
    class Program
    {
        private const ushort paso = 10;

        public static void Main(string[] args)
        {
            // las subs se invocan como comandos
            HolaMundo();

            // pueden recibir valores mediante parámetros
            Escribir("procedimiento escribe mensaje por parametro");
            int valor1, valor2;
            valor1 = 10;
            valor2 = 20;
            // un procedimiento permite reusar codigo
            Escribir("Primer valor: " + valor1);
            Escribir("Segundo valor: " + valor2);
            ImprimirMaximo(valor2, valor1);
            int maximo;
            // las funciones devuelven un valor
            // se pueden invocar a la derecha de la asignación
            maximo = (int)CalcularMaximo(valor1, valor2);
            Escribir("Máximo valor por función: " + maximo);

            // Paso de variables por valor y referencia
            double valor = 30d;
            Escribir("Byval y ByRef; Valor original: " + valor);
            PasoPorValor((float)valor);
            Escribir("Valor luego de afectar por valor: " + valor);
            float argdato = (float)valor;
            PasoPorReferencia(ref argdato);
            Escribir("Valor luego de afectar por referencia: " + argdato);
            
            // sobrecarga
            Escribir("Sobrecarga: ");
            // invoca el procedimiento según el número y tipos de parametros
            Escribir(Concatenar("hola", "Como te va?"));
            Escribir(Concatenar("hola", "Como te va?", "todo bien?"));
            Escribir(Concatenar("hola", 999));
        }

        // subrutinas realizan una tarea y no retorna valor alguno
        private static void HolaMundo()
        {
            // los procedimientos pueden invocar otros procedimientos
            Escribir("Ejecutando Subrutina hola Mundo");
        }
        // subrutinas pueden recibir parametros que afecten su comportamiento
        private static void Escribir(string cadena)
        {
            Console.WriteLine(cadena);
        }

        private static void ImprimirMaximo(float valor1, float valor2)
        {
            // las funciones se pueden invocar como expresiones
            Escribir("Máximo valor por procedimiento: " + CalcularMaximo(valor1, valor2));
        }
        // Las funciones realizan una tarea para devolver un valor
        private static float CalcularMaximo(float valor1, float valor2)
        {
            return Math.Max(valor1, valor2);
        }
        // dato es una copia de la variable original
        private static void PasoPorValor(float dato)
        {
            dato = dato + paso;
            Console.WriteLine("Valor mas {0}: " + dato, paso);
        }
        // dato es la misma instancia de la variable original
        private static void PasoPorReferencia(ref float dato)
        {
            dato = dato + paso;
            Console.WriteLine("Valor mas {0}: " + dato, paso);
        }
        // funciones sobrecargadas mismo nombre y mismo tipo de dato
        private static string Concatenar(string valor1, string valor2)
        {
            return valor1 + " - " + valor2;
        }

        private static string Concatenar(string valor1, int valor2)
        {
            return valor1 + " (" + valor2 + ")";
        }
        
        private static string Concatenar(string valor1, string valor2, string valor3)
        {
            return Concatenar(valor1, Concatenar(valor2, valor3));
        }


    }
}
