/*--------------------------------------------------------------------------------------
 * PROGRAMA:    Ejercicio 3, Examen Programación
 * AUTOR: 		Raúl Prieto Bailón
 * FUNCION: 	Pecera con pez 
 * FECHA 		21/11/2016	Versión 0.1
 * COMENTARIOS: --------
 * ---------------------------------------------------------------------------------*/
using System;

namespace Eje_3
{
	class Pecera
	{
		static void Main(string[] args)
		{
			// Declaro las variables
			char borde = ' ';
			int anchoPecera = 0;
			int altoPecera = 0;
			int xPez = 0;
			int yPez = 0;
			//Intro del programa
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			try
			{
				Console.WriteLine("Al introducir los datos de la pecera, tenga en cuenta las medidas.\nSi introduce unas coordenadas para el pez que sobrepasen\nlos limites de la pecera, éste no será impreso.\nTampoco introduzca dimensiones que superen las de la propia\nconsola, ya que se desbordará a la siguiente linea.\n");
				Console.Write("-Introduce el caracter para el borde de la pecera: ");
				borde = char.Parse(Console.ReadLine());
				Console.Write("-Introduce el ancho de la pecera: ");
				anchoPecera = int.Parse(Console.ReadLine());
				Console.Write("-Introduce el alto de la pecera: ");
				altoPecera = int.Parse(Console.ReadLine());				
				Console.Write("-Introduce coordenada X del pez: ");
				xPez = int.Parse(Console.ReadLine());
				Console.Write("-Introduce coordenada Y del pez: ");
				yPez = int.Parse(Console.ReadLine());
				
				// Datos de la pecera a imprimir
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n\tPecera formada por el caracter {0} de tamaño {1}x{2}\n\tEl pez está en la ({3},{4}).\n\n",borde,altoPecera,anchoPecera,yPez,xPez);
				Console.ForegroundColor = ConsoleColor.White;

				//BORDE superior
				BordePecera(anchoPecera, borde);

				//MEDIO pecera
				MedioPecera(altoPecera, anchoPecera, borde, yPez, xPez);

				//BORDE inferior
				BordePecera(anchoPecera, borde);				
			}
			catch 
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\n\tERROR: introduccion incorrecta. Reinicie el programa.");
			}
			Console.ReadLine(); //Evitamos que el programa finalice automáticamente			
		}

		#region Funciones del programa
		static void BordePecera(int ancho, char carBorde)
		{
			for (int i = 0; i < ancho; i++)
				{
					Console.Write(carBorde);
				}
			Console.WriteLine();
		}
		static void MedioPecera(int alto, int ancho, char carBorde, int yPez, int xPez)
		{
			for (int i = 0; i < alto-1; i++)
				{
					Console.Write(carBorde);
					for (int j = 0; j < ancho-2; j++)
					{
						Console.BackgroundColor = ConsoleColor.DarkCyan;
						if (i==yPez-1 && j==xPez-1)
						{
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.Write("*");
							j++; // Evitar desbordamiento en la linea
							Console.ForegroundColor = ConsoleColor.White;
						}
						Console.Write(" ");
						Console.BackgroundColor = ConsoleColor.Black;
					}
					Console.Write(carBorde);
					Console.WriteLine();
				}
		}
		#endregion
	}
}
