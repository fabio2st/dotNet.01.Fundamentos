Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("Hello World!")
		'Dividir()
		MostrarPaises()
	End Sub

	Sub Dividir()
		Dim dividendo, divisor As Decimal
		dividendo = IngresoDatos("Ingrese dividendo: ")
		divisor = IngresoDatos("Ingrese divisor: ")

		Try
			Dim resultado = dividendo / divisor
			Console.WriteLine("Resultado: " & resultado.ToString())
		Catch ex As DivideByZeroException
			Console.WriteLine("División por cero no es permitida")
		Catch
			Console.WriteLine("Error en la operación")
		End Try
		Console.WriteLine("Saliendo...")
	End Sub

	Private Function IngresoDatos(mensaje As String) As Decimal
		Do
			Try
				Dim valor As Decimal
				Console.Write(mensaje)
				valor = Convert.ToDecimal(Console.ReadLine())
				Return valor
			Catch ex As FormatException
				Console.WriteLine("Formato de entrada incompatible")
			Catch ex As Exception
				Console.WriteLine("Ha ocurrido un error en el ingreso de datos: " & ex.Message)
			End Try
		Loop While True
	End Function
	Private Sub MostrarPaises()
		Dim paises() = {"Argentina", "Brasil", "Paraguay", "Uruguay"}
		Dim reintentar As Char
		Do
			Console.WriteLine()
			For index = 0 To paises.Length - 1
				Console.WriteLine($"{index + 1}) {paises(index)}")
			Next

			Do
				Try
					Dim opcion As Byte
					Console.Write("Ingrese el codigo de pais: ")
					opcion = Convert.ToByte(Console.ReadLine())
					ValidarOpcionPais(opcion, paises)
					Console.WriteLine("Tu país elegido es: " & paises(opcion - 1))
					Exit Do
				Catch ex As FormatException
					Console.WriteLine("el formato del valor ingresado es incompatible")
				Catch ex As ArgumentException
					Console.WriteLine(ex.Message)
				Catch ex As Exception
					Console.WriteLine("Error no esperado: " & ex.Message)
				End Try
			Loop

			Console.Write("¿Desea elegir otro país? S afirmativo, cualquier otra tecla para salir ")
			reintentar = Console.ReadKey().KeyChar
		Loop While reintentar = "S" Or reintentar = "s"
	End Sub

	Private Sub ValidarOpcionPais(opcion As Byte, paises As String())
		If opcion < 1 Or opcion > paises.Count Then
			Throw New ArgumentException("El codigo de país no existe")
		End If
	End Sub
End Module
