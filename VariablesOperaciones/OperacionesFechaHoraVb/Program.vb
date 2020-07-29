Imports System

Module Program
    Sub Main(args As String())
        'Invocación a constructor
        'Console.WriteLine(date1);
        Dim ahora As DateTime = Date.Now()
        Console.WriteLine(ahora)
        Dim elDiaFinal As DateTime
        elDiaFinal = New DateTime(2000, 1, 1)
        Console.WriteLine(elDiaFinal)
        Dim elAsadoDelDiaFinal As DateTime = New DateTime(2000, 1, 1, 12, 30, 0)
        Console.WriteLine(elAsadoDelDiaFinal)
        Console.WriteLine("Hoy es el dia del año número: " & ahora.DayOfYear)
        Console.WriteLine("La hora del asado es: " & elAsadoDelDiaFinal.TimeOfDay.ToString)
        Console.WriteLine("El asado 60 días despues es: " & elAsadoDelDiaFinal.AddDays(60))
        Console.WriteLine("Del dia final al asado pasaron {0} horas", DateDiff(DateInterval.Hour,
                                                                               elDiaFinal, elAsadoDelDiaFinal))
        elAsadoDelDiaFinal = DateAdd(DateInterval.Day, 60, elDiaFinal)
        Console.WriteLine("El asado 60 días despues es: " & elAsadoDelDiaFinal)
        Console.WriteLine("Del dia final al asado pasaron {0} horas", DateDiff(DateInterval.Hour,
                                                                               elDiaFinal, elAsadoDelDiaFinal))

    End Sub
End Module
