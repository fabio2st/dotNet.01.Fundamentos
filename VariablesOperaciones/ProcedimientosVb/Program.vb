Imports System

Module Program
    Const paso As UShort = 10
    Sub Main(args As String())
        ' las subs se invocan como comandos
        holaMundo()

        'pueden recibir valores mediante parámetros
        Escribir("procedimiento escribe mensaje por parametro")

        Dim valor1, valor2 As Integer
        valor1 = 10
        valor2 = 20
        ' un procedimiento permite reusar codigo
        Escribir("Primer valor: " & valor1)
        Escribir("Segundo valor: " & valor2)

        ImprimirMaximo(valor2, valor1)

        Dim maximo As Integer
        ' las funciones devuelven un valor
        ' se pueden invocar a la derecha de la asignación
        maximo = CalcularMaximo(valor1, valor2)
        Escribir("Máximo valor por función: " & maximo)

        ' Paso de variables por valor y referencia
        Dim valor As Double = 30
        Escribir("Byval y ByRef; Valor original: " & valor)
        PasoPorValor(valor)
        Escribir("Valor luego de afectar por valor: " & valor)
        PasoPorReferencia(valor)
        Escribir("Valor luego de afectar por referencia: " & valor)

        ' sobrecarga
        Escribir("Sobrecarga: ")
        ' invoca el procedimiento según el número y tipos de parametros
        Escribir(Concatenar("hola", "Como te va?"))
        Escribir(Concatenar("hola", "Como te va?", "todo bien?"))
        Escribir(Concatenar("hola", 99))
    End Sub

    ' subrutinas realizan una tarea y no retorna valor alguno
    Private Sub holaMundo()
        ' los procedimientos pueden invocar otros procedimientos
        Escribir("Ejecutando Subrutina hola Mundo")
    End Sub
    ' subrutinas pueden recibir parametros que afecten su comportamiento
    Private Sub Escribir(cadena As String)
        Console.WriteLine(cadena)
    End Sub
    Private Sub ImprimirMaximo(valor1 As Single, valor2 As Single)
        ' las funciones se pueden invocar como expresiones
        Escribir("Máximo valor por procedimiento: " & CalcularMaximo(valor1, valor2))
    End Sub
    ' Las funciones realizan una tarea para devolver un valor
    Private Function CalcularMaximo(valor1 As Single, valor2 As Single) As Single
        Return Math.Max(valor1, valor2)
    End Function
    ' dato es una copia de la variable original
    Private Sub PasoPorValor(ByVal dato As Single)
        dato = dato + paso
        Console.WriteLine("Valor mas {0}: " & dato, paso)
    End Sub
    ' dato es la misma instancia de la variable original
    Private Sub PasoPorReferencia(ByRef dato As Single)
        dato = dato + paso
        Console.WriteLine("Valor mas {0}: " & dato, paso)
    End Sub
    ' funciones sobrecargadas mismo nombre y mismo tipo de dato
    Private Function Concatenar(valor1 As String, valor2 As String) As String
        Return valor1 & " - " & valor2
    End Function
    Private Function Concatenar(valor1 As String, valor2 As String, valor3 As String) As String
        Return valor1 & " - " & valor2 & " - " & valor3
    End Function
    Private Function Concatenar(valor1 As String, valor2 As Integer) As String
        Return valor1 & " (" & valor2 & ")"
    End Function

End Module
