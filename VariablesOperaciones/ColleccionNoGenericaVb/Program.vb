Imports System
Imports System.Formats
Module Program
    Sub Main(args As String())
        Dim lista As New ArrayList()
        lista.Add(1)
        lista.Add(2)
        lista.Add("3")

        Dim Sum As Integer
        For Each item In lista
            Sum += Convert.ToInt32(item)
        Next

        Console.WriteLine($"La suma es {Sum}")
    End Sub
End Module
