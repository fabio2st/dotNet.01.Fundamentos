Imports System

Module Program
    Enum FigurasCartasEspañolas
        Oro
        Espada
        Basto
        Copa
    End Enum
    Sub Main(args As String())
        ' declaración del tipo numerado
        Dim figura As FigurasCartasEspañolas
        ' asignación de valor
        figura = FigurasCartasEspañolas.Oro
        ' obtener valor numerado y representación de cadena
        Console.WriteLine("Figura {0} es {1}", figura.GetHashCode, figura.ToString)
        figura = FigurasCartasEspañolas.Copa
        Console.WriteLine("Figura {0} es {1}", figura.GetHashCode, figura.ToString)
        Console.WriteLine("¿Figura {0} es {1}?: {2}",
                          figura.GetHashCode, FigurasCartasEspañolas.Espada, figura = FigurasCartasEspañolas.Espada)
        figura = FigurasCartasEspañolas.Espada
        Console.WriteLine("¿Figura {0} es {1}?: {2}",
                          figura.GetHashCode, FigurasCartasEspañolas.Espada, figura = FigurasCartasEspañolas.Espada)

        Dim existe As Boolean
        ' asignar valor numérico a tipo numerado
        figura = 18
        ' evalua si el valor existe en la enumeración
        existe = [Enum].IsDefined(GetType(FigurasCartasEspañolas), figura)
        Console.WriteLine("Figura {0} ¿existe?: {1}", figura, existe)

        figura = 2
        existe = [Enum].IsDefined(GetType(FigurasCartasEspañolas), figura)
        Console.WriteLine("Figura {0} ¿existe?: {1}", figura, existe)
        Console.WriteLine("Figura escogida: " & figura & " - " & figura.ToString)
    End Sub
End Module
