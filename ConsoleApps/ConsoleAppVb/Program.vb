Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Bienvenido, presiona una tecla para operar")
        Console.ReadKey()
        ' declaración de variables
        Dim nombre, apellido As String
        Console.Write("Ingresa tu nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingresa tu apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("Hola " + nombre + " " + apellido)
    End Sub
End Module
