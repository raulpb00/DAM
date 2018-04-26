using System;
using System.Collections.Generic;
using System.Text;
//-----------------------------------
using System.Threading;
using System.IO;

namespace Examen2eRec18
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo opcion;
			bool salida = false;
			do
			{
				MenuPrincipal();
				opcion = Console.ReadKey();

				switch (opcion.Key)
				{
					case ConsoleKey.A:
						if (!CuentaPalabras())
						{
							Console.WriteLine("\n\n Arregle el fichero y vuelva a intentarlo más tarde.");
							Console.CursorVisible = false;
							Console.ReadKey(true);
							Console.CursorVisible = true;
						}
						break;
					case ConsoleKey.B:
						DiasVividos();
						Console.CursorVisible = false;
						Console.ReadKey(true);
						Console.CursorVisible = true;
						break;
					case ConsoleKey.C:
						ComandasPizzas();
						Console.CursorVisible = false;
						Console.ReadKey(true);
						Console.CursorVisible = true;
						break;
					case ConsoleKey.Escape:
						Console.Write("\n\n\t Está seguro de que desea salir? s/n: ");
						do
						{
							opcion = Console.ReadKey(true);
							if (opcion.Key == ConsoleKey.S)
							{
								Console.WriteLine("\n\n ¡Hasta Pronto!");
								Thread.Sleep(500);
								salida = true;
								break;
							}
						} while (opcion.Key != ConsoleKey.S && opcion.Key != ConsoleKey.N);
						break;
					default:
						break;
				}

			} while (!salida);
		}

		public static void DiasVividos()
		{
			DateTime fechaIntroducida;
			TimeSpan diasVividos;

			Console.Clear();

			fechaIntroducida = PedirFecha();

			diasVividos = DateTime.Now - fechaIntroducida;

			Console.WriteLine("Días Vividos: " + diasVividos.Days);

		}

		static DateTime PedirFecha()
		{
			DateTime fechaIntroducida;
			do
			{
				try
				{
					Console.WriteLine(" Introduce una fecha de nacimiento para nacidos \ndespués del 1900 y antes del 2015. \n\t(dd/mm/aaaa)/(dd/mm/aa)");
					Console.Write("  Fecha: ");
					fechaIntroducida = DateTime.Parse(Console.ReadLine());

					Console.WriteLine();
					if (fechaIntroducida.Year > 1900 && fechaIntroducida.Year < 2015)
						return fechaIntroducida;
					else
						Console.WriteLine(" La fecha no es correcta.");
				}
				catch (Exception)
				{
					Console.WriteLine("Error, fecha no válida. (dd/mm/aaaa)/(dd/mm/aa)\n");
				}
			} while (true);
		}

		public static void ComandasPizzas()
		{
			Console.Clear();

			Pizza p1 = new Pizza(Pizza.Tamano.Pequeña, Pizza.Tipo.Cuatro_Quesos);
			Pizza p2 = new Pizza(Pizza.Tamano.Familiar, Pizza.Tipo.Especial);
			Pizza p3 = new Pizza(Pizza.Tamano.Pequeña, Pizza.Tipo.Especial);
			Console.WriteLine(p1);
			Console.WriteLine(p2);
			Console.WriteLine(p3);
			p2.Servir();
			Console.WriteLine(p2.Servir());

			Console.WriteLine("Total Pizzas Pedidas: " + Pizza.PizzasPedidas);
			Console.WriteLine("Total Pizzas Servidas: " + Pizza.PizzasServidas);
		}

		public static bool CuentaPalabras()
		{
			string ruta = @"c:\basura\fichero.txt";
			char tmpCar = ' ';
			bool finPalabra = false;
			string tmpPalabra = string.Empty;
			string palabraMasLarga = string.Empty;
			int nPalabras = 0;
			int nMasLarga = 0;
			List<string> palindromos = new List<string>();

			Console.Clear();
			try
			{
				using (FileStream flujo = new FileStream(ruta, FileMode.Open, FileAccess.Read))
				{
					using (StreamReader lector = new StreamReader(flujo, Encoding.UTF8))
					{
						while (!lector.EndOfStream)
						{
							do
							{
								tmpCar = (char)lector.Read(); // Leo un caracter
								if (tmpCar == ' ' || tmpCar == '\n' || tmpCar == '\r' || tmpCar == '.' || tmpCar == ',')
									finPalabra = true;
								else
									tmpPalabra += tmpCar;
							} while (!finPalabra && !lector.EndOfStream);

							// ¿Numero de palabras? 
							if (tmpPalabra != string.Empty)
								nPalabras++;

							// ¿Palindromo?
							if (EsPalindromo(tmpPalabra) && tmpPalabra.Length > 2)
							{
								if (!palindromos.Contains(tmpPalabra)) // Si no está en la lista, la guardo
									palindromos.Add(tmpPalabra);
							}

							// ¿Palabra más larga / veces palabra más larga?
							if (tmpPalabra == palabraMasLarga)
								nMasLarga++;
							else if (tmpPalabra.Length > palabraMasLarga.Length)
							{
								palabraMasLarga = tmpPalabra;
								nMasLarga = 1;
							}

							//---------------------------------------
							// Resetear variables temporales
							finPalabra = false;
							tmpPalabra = string.Empty;

						}
					}

					Console.WriteLine("┌─────────────────────────────────────────────┐");
					Console.WriteLine("│        .-CONTAR PALABRAS-.                  │");
					Console.WriteLine("└─────────────────────────────────────────────┘\n");
					Console.WriteLine(" - Número total de palabras: {0}", nPalabras);
					Console.Write(" - Lista de palíndromos: ");
					foreach (string palin in palindromos)
					{
						Console.Write("{0}, ", palin);
					}
					Console.WriteLine("\b\b. ");
					Console.WriteLine(" - Palabra más larga y su longitud: {0} - {1} caracteres.", palabraMasLarga, palabraMasLarga.Length);
					Console.WriteLine(" - Número de veces que está la palabra más larga: " + nMasLarga);

					Console.ReadKey(true);
					Console.WriteLine("\n\n\n\t  Pulse una tecla para volver al menú principal.");
					return true;
				}

			}
			catch (Exception e)
			{
				Console.Clear();
				Console.WriteLine("\n\n\n\t ERROR: " + e.Message);
				return false;
			}
		}

		public static bool EsPalindromo(string palabra)
		{
			string alReves = string.Empty;
			palabra = palabra.ToLower(); // Normalizo la palabra para comprobar si es palíndromo

			for (int i = palabra.Length - 1; i >= 0; i--)
			{
				alReves += palabra[i];
			}

			if (palabra == alReves)
				return true;
			else
				return false;
		}

		public static void MenuPrincipal()
		{
			int tOpcion = 0;
			int lOpcion = 0;
			Console.Clear();
			Console.WriteLine("┌─────────────────────────────────────────────┐");
			Console.WriteLine("│        MENU PRINCIPAL 2eRec                 │");
			Console.WriteLine("├─────────────────────────────────────────────┤");
			Console.WriteLine("│  a. Cuenta palabras.                        │");
			Console.WriteLine("│                                             │");
			Console.WriteLine("│  b. Calcular los días vividos               │");
			Console.WriteLine("│                                             │");
			Console.WriteLine("│  c. Pizzería                                │");
			Console.WriteLine("│                                             │");
			Console.WriteLine("│                                             │");
			Console.WriteLine("│                        Pulse ESC para salir.│");
			Console.WriteLine("├─────────────────────────────────────────────┤");
			Console.Write("│ Opción: ");
			tOpcion = Console.CursorTop;
			lOpcion = Console.CursorLeft;
			Console.WriteLine("                                    │");
			Console.WriteLine("└─────────────────────────────────────────────┘");
			Console.SetCursorPosition(lOpcion, tOpcion);
		}
	}
}
