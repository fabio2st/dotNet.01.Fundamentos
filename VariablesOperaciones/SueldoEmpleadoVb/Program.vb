Imports System

Module Program
    Sub Main(args As String())
        Dim horasTrabajadas As Byte
        Dim valorHora As UShort
        'Dim sueldo As UInteger
        Dim descuento, sueldo As Decimal
        valorHora = 500

        Console.Write("Ingrese la cantidad de horas trabajadas: ")
        horasTrabajadas = Console.ReadLine()
        Console.Write("Ingrese el descuento (negativo): ")
        descuento = Console.ReadLine()
        sueldo = horasTrabajadas * valorHora
        Console.WriteLine("El sueldo bruto es: " & sueldo)
        sueldo += sueldo * descuento / 100
        Console.WriteLine("El sueldo total es: " & sueldo)
    End Sub
End Module
