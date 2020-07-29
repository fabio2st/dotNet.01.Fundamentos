using System;

namespace OperacionesFechaHoraCs
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocación de constructor
            var dateOnly = new DateTime(2020, 8, 1);
            Console.WriteLine("Solo fecha: " + dateOnly);
            var dateTime = new DateTime(2020, 8, 1, 20, 24, 52);
            Console.WriteLine("Fecha hora: " + dateTime);
            var dateTimeDefault = new DateTime();
            Console.WriteLine("Fecha hora pedeterminada: " + dateTimeDefault);
            // asignación de valor
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Fecha hora ahora: " + dateNow);
            DateTime dateUtc = DateTime.UtcNow;
            Console.WriteLine("Fecha hora UTC: " + dateUtc);
            DateTime dateToday = DateTime.Today;
            Console.WriteLine("Fecha hora hoy: " + dateToday);
            // Por conversión de cadena
            var iso8601String = "20200801T20:30:52Z";
            DateTime dateISO8602 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ",
                                            System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Fecha hora parsed: " + dateISO8602);
            // Fecha hora literal SOLO VB
            // DateTime dateLiteral = #3/1/2008 7:00AM#;

            // Propiedades de instancia
            Console.WriteLine("Fecha: " + dateISO8602.Date);
            Console.WriteLine("Hora: " + dateISO8602.TimeOfDay);
            Console.WriteLine("Mes: " + dateISO8602.Month);
            // Propiedades de estructura
            Console.WriteLine("Ahora: " + DateTime.Now);
            Console.WriteLine("Día del año: " + DateTime.Now.DayOfYear);
            // Metodos
            int dias = 60;
            Console.WriteLine("{0} días despues es: {1}", dias, dateISO8602.AddDays(dias));
            Console.WriteLine("{0} días antes es: {1}", dias, dateISO8602.AddDays(-dias));
            Console.WriteLine("Compara {0} y {1}: {2}", dateISO8602, dateNow, dateISO8602.CompareTo(dateNow));

            // Calcular el intervalo entre dos fechas dates.
            TimeSpan intervalo = dateISO8602 - dateNow;
            Console.WriteLine("{0} - {1} = {2}", dateISO8602, dateNow, intervalo.ToString());
            Console.WriteLine("Intervalo de dias: " + intervalo.Days);
            Console.WriteLine("Intervalo de horas: " + intervalo.Hours);
            Console.WriteLine("Intervalo total de Horas: " + intervalo.TotalHours);
        }
    }
}