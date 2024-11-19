Imports System

Module Program
	Sub Main(args As String())
        Console.WriteLine("Hello Colecciones!")
        Suma()
        Paises()
    End Sub

    Sub Suma()
        Dim lista As New List(Of Integer)
        lista.Add(1)
        lista.Add(2)
        lista.Add("3")

        Dim Sum As Integer
        For Each item In lista
            Sum += Convert.ToInt32(item)
        Next

        Console.WriteLine($"La suma es {Sum}")
        Console.WriteLine($"La suma es {lista.Sum()}")

    End Sub

    Sub Paises()
        Dim paises As New List(Of String)
        paises.Add("Argentina")
        paises.Add("Brasil")
        paises.Add("Uruguay")
        paises.Add("Paraguay")
        paises.Add("Chile")

        ' iterar con indice
        For index = 0 To paises.Count() - 1
            Console.WriteLine(paises(index))
        Next

        ' cambiar un valor
        paises(4) = "Bolivia"

        Dim otrosPaises() As String = {"Venezuela", "Ecuador", "Colombia"}
        paises.AddRange(otrosPaises)

        Console.WriteLine(paises.Contains("Chile"))
        Console.WriteLine(paises.Contains("Bolivia"))

        paises.Insert(4, "Chile")

        paises.Sort()
        paises.Reverse()

        Console.WriteLine(paises.IndexOf("Brasil"))
        Console.WriteLine(paises.IndexOf("None"))

        For Each item As String In paises.Where(Function(pais) pais.Contains("r"))
            Console.WriteLine(item)
        Next

        paises.Remove("Venezuela")
        paises.RemoveAt(4)
        paises.Clear()
    End Sub
End Module
