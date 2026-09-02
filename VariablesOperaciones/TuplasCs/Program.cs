// Declaración y acceso
(string Nombre, int Edad, bool Activo) persona1 = ("Juana", 30, true);
Console.WriteLine(persona1.Nombre);
Console.WriteLine(persona1.Edad);

// Sin nombres — acceso por Item1, Item2 (válido pero menos legible)
(string, int) par = ("Luis", 25);
Console.WriteLine(par.Item1);  // "Luis"
Console.WriteLine(par.Item2);  // 25

// Retornar múltiples valores de un método
DateTime fechaHoraActual = DateTime.Now;
var fechaHoraTupla = FechaHoraSeparado(fechaHoraActual);
Console.WriteLine(fechaHoraTupla.Año);
Console.WriteLine(fechaHoraTupla.Mes);
Console.WriteLine(fechaHoraTupla.Día);
Console.WriteLine(fechaHoraTupla.Hora);
Console.WriteLine(fechaHoraTupla.Minuto);

(int Año, int Mes, int Día, int Hora, int Minuto) FechaHoraSeparado(DateTime fechaHoraActual)
{
    return (fechaHoraActual.Year, fechaHoraActual.Month, fechaHoraActual.Day, fechaHoraActual.Hour, fechaHoraActual.Minute);
}

// Deconstrucción de tuplas
var persona2 = ("María", 28, "Argentina");

// Deconstrucción completa
var (nombre, edad, pais) = persona2;
Console.WriteLine($"{nombre} tiene {edad} años");  // María tiene 28 años

// Descartar valores que no interesan con _
var (_, _, nacionalidad) = persona2;
Console.WriteLine(nacionalidad);  // Argentina

// Comparación por valor
var t1 = (1, "hola");
var t2 = (1, "hola");
Console.WriteLine(t1 == t2);  // true
var t3 = (2, "hola");
Console.WriteLine(t1 == t3);  // true

// Swap elegante sin variable auxiliar
int a = 10, b = 20;
(a, b) = (b, a);
Console.WriteLine($"a={a}, b={b}");  // a=20, b=10

// Como parámetro de método
MostrarPunto((3.5, 7.2));
void MostrarPunto((double X, double Y) punto)
{
    Console.WriteLine($"({punto.X}, {punto.Y})");
}