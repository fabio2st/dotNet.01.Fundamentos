using System;

namespace Enumeraciones
{
    enum FigurasCartasEspañolas
    {
        Oro,
        Espada,
        Basto = 5,  // asignación de valor arbitrario
        Copa
    }

    class Program
    {
        static void Main(string[] args)
        {
            // declaración del tipo numerado
            FigurasCartasEspañolas figura;
            // asignación de valor
            figura = FigurasCartasEspañolas.Oro;
            // obtener valor numerado y representación de cadena
            Console.WriteLine("Figura {0} es {1}", figura.GetHashCode(), figura.ToString());
            // establecer un valor al tipo numerado
            figura = FigurasCartasEspañolas.Copa;
            Console.WriteLine("Figura {0} es {1}", figura.GetHashCode(), figura.ToString());
            // comparar valores del tipo numerado
            Console.WriteLine("¿Figura {0} es {1}?: {2}", 
                figura.GetHashCode(), FigurasCartasEspañolas.Espada, figura == FigurasCartasEspañolas.Espada);
            figura = FigurasCartasEspañolas.Espada;
            Console.WriteLine("¿Figura {0} es {1}?: {2}", 
                figura.GetHashCode(), FigurasCartasEspañolas.Espada, figura == FigurasCartasEspañolas.Espada);
            
            bool existe;
            // asignar valor numérico a tipo numerado
            figura = (FigurasCartasEspañolas)18;
            // evalua si el valor existe en la enumeración
            existe = Enum.IsDefined(typeof(FigurasCartasEspañolas), figura);
            Console.WriteLine("Figura {0} ¿existe?: {1}", figura, existe);
            figura = (FigurasCartasEspañolas)5;
            existe = Enum.IsDefined(typeof(FigurasCartasEspañolas), figura);
            Console.WriteLine("Figura {0} ¿existe?: {1}", figura, existe);
            Console.WriteLine("Figura escogida: " + ((int)figura).ToString() + " - " + figura.ToString());
        }
    }
}