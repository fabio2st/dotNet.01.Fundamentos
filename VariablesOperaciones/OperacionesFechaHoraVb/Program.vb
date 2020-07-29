Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())
        ' invocación de constructor
        Dim dateOnly = New DateTime(2020, 8, 1)
        Console.WriteLine("Solo fecha: " & dateOnly)
        Dim dateTime = New DateTime(2020, 8, 1, 20, 24, 52)
        Console.WriteLine("Fecha hora: " & dateTime)
        Dim dateTimeDefault = New DateTime()
        Console.WriteLine("Fecha hora pedeterminada: " & dateTimeDefault)
        ' asignación de valor
        Dim dateNow = DateTime.Now
        Console.WriteLine("Fecha hora ahora: " & dateNow)
        Dim dateUtc = DateTime.UtcNow
        Console.WriteLine("Fecha hora UTC: " & dateUtc)
        Dim dateToday = DateTime.Today
        Console.WriteLine("Fecha hora hoy: " & dateToday)
        ' Por conversión de cadena
        Dim iso8601String = "20200801T20:30:52Z"
        Dim dateISO8602 = Date.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ", CultureInfo.InvariantCulture)
        Console.WriteLine("Fecha hora parsed: " & dateISO8602)
        ' Fecha hora literal SOLO VB
        Dim dateLiteral As DateTime = #3/1/2008 7:00AM#
        Console.WriteLine("Fecha hora parsed: " & dateLiteral)

        ' Propiedades de instancia
        Console.WriteLine("Fecha: " & dateISO8602.Date)
        Console.WriteLine("Hora: " & dateISO8602.TimeOfDay.ToString)
        Console.WriteLine("Mes: " & dateISO8602.Month)
        ' Propiedades de estructura
        Console.WriteLine("Ahora: " & DateTime.Now)
        Console.WriteLine("Día del año: " & DateTime.Now.DayOfYear)
        ' Metodos
        Dim dias = 60
        Console.WriteLine("{0} días despues es: {1}", dias, dateISO8602.AddDays(dias))
        Console.WriteLine("{0} días antes es: {1}", dias, dateISO8602.AddDays(-dias))
        Console.WriteLine("Compara {0} y {1}: {2}", dateISO8602, dateNow, dateISO8602.CompareTo(dateNow))

        ' Calcular el intervalo entre dos fechas dates.
        Dim intervalo As TimeSpan = dateISO8602 - dateNow
        Console.WriteLine("{0} - {1} = {2}", dateISO8602, dateNow, intervalo.ToString())
        Console.WriteLine("Intervalo de dias: " & intervalo.Days)
        Console.WriteLine("Intervalo de horas: " & intervalo.Hours)
        Console.WriteLine("Intervalo total de Horas: " & intervalo.TotalHours)
    End Sub
End Module
