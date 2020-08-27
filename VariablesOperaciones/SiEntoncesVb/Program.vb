Imports System

Module Program
    Sub Main(args As String())
        Dim a As Short
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine
        If a > 0 Then
            Console.WriteLine("Es positivo")
        End If

        If a > 0 Then
            Console.WriteLine("Es positivo")
        Else
            Console.WriteLine("No Es positivo")
        End If

        If a > 0 Then
            Console.WriteLine("Es positivo")
        ElseIf a < 0 Then
            Console.WriteLine("Es negativo")
        Else
            Console.WriteLine("Es cero")
        End If
    End Sub
End Module
