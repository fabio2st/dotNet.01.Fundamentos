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

        Dim value = If(a > 0, "Es positivo", If(a < 0, "Es negativo", "Es cero"))
        Console.WriteLine(value)

        Dim b As Short = Convert.ToInt16(Console.ReadLine())
        Dim c As Short = Convert.ToInt16(Console.ReadLine())

        If a > b AndAlso a > c Then
            Console.WriteLine("A es mayor que b y c")
        End If

        If a > b OrElse a > c Then
            Console.WriteLine("A es mayor que b o c")
        End If

        If (a > c OrElse a > b) AndAlso b > c Then
            Console.WriteLine("resultado esperado")
        End If

    End Sub
End Module
