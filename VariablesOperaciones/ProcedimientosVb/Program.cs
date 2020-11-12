using System;

namespace ProcedimientosVb
{
    static class Program
    {
        private const ushort paso = 10;

        public static void Main(string[] args)
        {
            // las subs se invocan como comandos
            holaMundo();

            // pueden recibir valores mediante parámetros
            escribir("procedimiento escribe mensaje por parametro");
            int valor1, valor2;
            valor1 = 10;
            valor2 = 20;
            // un procedimiento permite reusar codigo
            escribir("Primer valor: " + valor1);
            escribir("Segundo valor: " + valor2);
            imprimirMaximo(valor2, valor1);
            int maximo;
            // las funciones devuelven un valor
            // se pueden invocar a la derecha de la asignación
            maximo = (int)calcularMaximo(valor1, valor2);
            escribir("Máximo valor por función: " + maximo);

            // Paso de variables por valor y referencia
            double valor = 30d;
            escribir("Byval y ByRef; Valor original: " + valor);
            pasoPorValor((float)valor);
            escribir("Valor luego de afectar por valor: " + valor);
            float argdato = (float)valor;
            pasoPorReferencia(ref argdato);
            escribir("Valor luego de afectar por referencia: " + valor);

            // sobrecarga
            escribir("Sobrecarga: ");
            // invoca el procedimiento según el número y tipos de parametros
            escribir(concatenar("hola", "Como te va?"));
            escribir(concatenar("hola", "Como te va?", "todo bien?"));
            escribir(concatenar("hola", 999));
        }

        // subrutinas realizan una tarea y no retorna valor alguno
        private static void holaMundo()
        {
            // los procedimientos pueden invocar otros procedimientos
            escribir("Ejecutando Subrutina hola Mundo");
        }
        // subrutinas pueden recibir parametros que afecten su comportamiento
        private static void escribir(string cadena)
        {
            Console.WriteLine(cadena);
        }

        private static void imprimirMaximo(float valor1, float valor2)
        {
            // las funciones se pueden invocar como expresiones
            escribir("Máximo valor por procedimiento: " + calcularMaximo(valor1, valor2));
        }
        // Las funciones realizan una tarea para devolver un valor
        private static float calcularMaximo(float valor1, float valor2)
        {
            return Math.Max(valor1, valor2);
        }
        // dato es una copia de la variable original
        private static void pasoPorValor(float dato)
        {
            dato = dato + paso;
            Console.WriteLine("Valor mas {0}: " + dato, paso);
        }
        // dato es la misma instancia de la variable original
        private static void pasoPorReferencia(ref float dato)
        {
            dato = dato + paso;
            Console.WriteLine("Valor mas {0}: " + dato, paso);
        }
        // funciones sobrecargadas mismo nombre y mismo tipo de dato
        private static string concatenar(string valor1, string valor2)
        {
            return valor1 + " - " + valor2;
        }

        private static string concatenar(string valor1, string valor2, string valor3)
        {
            return valor1 + " - " + valor2 + " - " + valor3;
        }

        private static string concatenar(string valor1, int valor2)
        {
            return valor1 + " (" + valor2 + ")";
        }
    }
}