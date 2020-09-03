Imports System

Module Program
    Enum Menu
        Alta
        Editar
        Baja
        Salir
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Menu de opciones")
        Dim opcion As Menu
        opcion = Menu.Alta
        Console.WriteLine("{0}) {1}", opcion.GetHashCode, opcion.ToString())

        Console.Write("Ingrese una opcion: ")

        Select Case opcion
            Case Menu.Alta
                ' Do something!
        End Select


    End Sub
End Module
