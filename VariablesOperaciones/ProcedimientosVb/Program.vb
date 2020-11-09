Imports System

Module Program
    Const paso As UShort = 10
    Sub Main(args As String())
        ' las subs se invocan como comandos
        holaMundo()
        escribir("procedimiento escribe mensaje por parametro")
        Dim valor1, valor2 As Integer
        valor1 = 10
        valor2 = 20
        escribir("Primer valor: " & valor1)
        escribir("Segundo valor: " & valor2)
        imprimirMaximo(valor2, valor1)
        Dim maximo As Integer
        ' las funciones se pueden invocar a la derecha de la asignación
        maximo = calcularMaximo(valor1, valor2)
        escribir("Máximo valor por función: " & maximo)
        ' Paso de variables por valor y referencia
        Dim valor As Double = 30
        escribir("Byval y ByRef; Valor original: " & valor)
        pasoPorValor(valor)
        escribir("Valor luego de afectar por valor: " & valor)
        pasoPorReferencia(valor)
        escribir("Valor luego de afectar por referencia: " & valor)
        ' sobrecarga
        escribir("Sobrecarga: ")
        ' invoca el procedimiento según el número y tipos de parametros
        escribir(concatenar("hola", "Como te va?"))
        escribir(concatenar("hola", 999))
        escribir(concatenar("hola", "Como te va?", "todo bien?"))
    End Sub

    ' subrutinas realizan una tarea y no retorna valor alguno
    Private Sub holaMundo()
        ' los procedimientos pueden invocar otros procedimientos
        escribir("Ejecutando Subrutina hola Mundo")
    End Sub
    ' subrutinas pueden recibir parametros que afecten su comportamiento
    Private Sub escribir(cadena As String)
        Console.WriteLine(cadena)
    End Sub
    Private Sub imprimirMaximo(valor1 As Single, valor2 As Single)
        ' las funciones se pueden invocar como expresiones
        escribir("Máximo valor por procedimiento: " & calcularMaximo(valor1, valor2))
    End Sub
    ' Las funciones realizan una tarea para devolver un valor
    Private Function calcularMaximo(valor1 As Single, valor2 As Single) As Single
        Return Math.Max(valor1, valor2)
    End Function
    ' dato es una copia de la variable original
    Private Sub pasoPorValor(ByVal dato As Single)
        dato = dato + paso
        Console.WriteLine("Valor mas {0}: " & dato, paso)
    End Sub
    ' dato es la misma instancia de la variable original
    Private Sub pasoPorReferencia(ByRef dato As Single)
        dato = dato + paso
        Console.WriteLine("Valor mas {0}: " & dato, paso)
    End Sub
    ' funciones sobrecargadas mismo nombre y mismo tipo de dato
    Private Function concatenar(valor1 As String, valor2 As String) As String
        Return valor1 & " - " & valor2
    End Function
    Private Function concatenar(valor1 As String, valor2 As Integer) As String
        Return valor1 & " (" & valor2 & ")"
    End Function
    Private Function concatenar(valor1 As String, valor2 As String, valor3 As String) As String
        Return valor1 & " - " & valor2 & " - " & valor3
    End Function
End Module
