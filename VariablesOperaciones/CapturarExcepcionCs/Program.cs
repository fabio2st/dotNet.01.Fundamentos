using Microsoft.VisualBasic;

namespace CapturarExcepcionCs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Dividir();
			MostrarPaises();
		}

		static void Dividir()
		{
			decimal dividendo, divisor;
			dividendo = IngresoDatos("Ingrese dividendo: ");
			divisor = IngresoDatos("Ingrese divisor: ");

			try
			{
				var resultado = dividendo / divisor;
				Console.WriteLine("Resultado: " + resultado);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("División por cero no es permitida");
			}
			catch (Exception)
			{
				Console.WriteLine("Error en la operación");
			}
			Console.WriteLine("Saliendo...");
		}

		private static decimal IngresoDatos(string mensaje)
		{
			do
			{
				try
				{
					decimal valor;
					Console.Write(mensaje);
					valor = Convert.ToDecimal(Console.ReadLine());
					return valor;
				}
				catch (FormatException)
				{
                    Console.WriteLine("Formato de entrada incompatible");
                }
				catch (Exception ex)
				{
					Console.WriteLine("Ha ocurrido un error en el ingreso de datos: " + ex.Message);
				}
			} while (true);
		}
		private static void MostrarPaises()
		{
			string[] paises = new string[] { "Argentina", "Brasil", "Paraguay", "Uruguay" };
			char reintentar;
			do
			{
				Console.WriteLine();
				for (int index = 0, loopTo = paises.Length - 1; index <= loopTo; index++)
					Console.WriteLine($"{index + 1}) {paises[index]}");

				do
				{
					try
					{
						byte opcion;
						Console.Write("Ingrese el codigo de pais: ");
						opcion = Convert.ToByte(Console.ReadLine());
						ValidarOpcionPais(opcion, paises);
						Console.WriteLine("Tu país elegido es: " + paises[opcion - 1]);
						break;
					}
					catch (FormatException ex)
					{
						Console.WriteLine("el formato del valor ingresado es incompatible");
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.Message);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error no esperado: " + ex.Message);
					}
				}
				while (true);

				Console.Write("¿Desea elegir otro país? S afirmativo, cualquier otra tecla para salir ");
				reintentar = Console.ReadKey().KeyChar;
			}
			while (reintentar == 'S' || reintentar == 's');
		}

		private static void ValidarOpcionPais(byte opcion, string[] paises)
		{
			if (opcion < 1 | opcion > paises.Count())
			{
				throw new ArgumentException("El codigo de país no existe");
			}
		}
	}
}
