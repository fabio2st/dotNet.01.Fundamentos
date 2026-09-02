// Error de compilación: Tipos por valor no admiten null por defecto
//int x = null;
//bool b = null;
//double d = null;

// Tipos por valor pueden ser nulos si se declaran como nullable
int? edad = null;
bool? activo = null;
double? precio = null;
DateTime? vencimiento = null;

// Por naturaleza, una variable de tipo referencia puede no apuntar a ningún objeto
string nombre = null;
int[] numeros = null;
object obj = null;
string? apellido = null;  // Declarado explicitamente como nullable, sin advertencia
string? texto = null;

// El compilador también avisa si se usa sin verificar posible NullReferenceException
//Console.WriteLine(nombre.Length);    // Error en tiempo de ejecución si nombre es null

// Operar el valor de forma segura
if (edad.HasValue)  // falso
    Console.WriteLine($"Edad: {edad.Value}");

// is null / is not null — la forma más clara de verificar
if (texto is null)
    Console.WriteLine("Es nulo");
apellido = "Perez";
if (apellido is not null)
    Console.WriteLine($"Tiene {apellido.Length} caracteres");

// Operador ?? — null coalescing: valor predeterminado si es null
int edadReal = edad ?? 0;
string nombreReal = nombre ?? "Sin valor";
// asigna solo si es null
texto ??= "valor inicial";      
texto ??= "Otro valor";

// Operador ? — null conditional: no ejecuta si es null (acceso seguro)
int? largo = nombre?.Length;
largo = texto?.Length;
Console.WriteLine(nombre?.Length);
Console.WriteLine(apellido?.Length);
Console.WriteLine(edad?.ToString() ?? "Sin datos");

// ! — null forgiving
string advertido = texto; // con advertencia del compilador
string forzado = texto!; // suprime la advertencia, riesgoso