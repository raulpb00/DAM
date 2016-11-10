using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Calcular
{
	class App_Calcular
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int nParametros = args.Length;
			double radio;
			double altura;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			if (nParametros == 0)	// Faltan parametros
			{
				Console.WriteLine("Faltan parametros ... \n");
				Console.WriteLine(" Usa App_Calcular ?     Para mostrar esta ayuda");
			}
			if (nParametros == 1)	// Parametro para llamar la ayuda
			{
				if (args[0] !="?")
					return;
				Ayuda();
			}
			if (nParametros == 2)
			{
				try
				{
					radio = double.Parse(args[2]);
					
					if (args[0].ToLower() == "l" )
					{
						Console.WriteLine("La longitud de la circunferencia de radio {0} es {1}.",radio , Longitud(radio));
					}
					if (args[0].ToLower() == "a" )
					{
						Console.WriteLine("La longitud de la circunferencia de radio {0} es {1}.",radio , Area(radio));
					}		
				}
				catch
				{
					Console.WriteLine("ERROR: En parametro radio. Usa App_Calcular ?     Para mostrar esta ayuda");	
				}
			}
			if (nParametros == 3)
			{
				try
				{
					altura = double.Parse(args[1]);
					radio = double.Parse(args[2]);
					if (args[0].ToLower() == "v" )
					{
						Console.WriteLine("El volumen de la circunferencia de radio {0} y altura {1} es {2:E}.",radio , altura, Volumen(radio, altura));
					}					
				}
				catch
				{
					Console.WriteLine("ERROR: En parametro radio. Usa App_Calcular ?     Para mostrar esta ayuda");	
				}
			}

			if (nParametros > 3)	// Demasiados parametros
			{
				
			}


			Console.ReadLine();
		}

		#region  Metodos App_Calcular.

		static void Ayuda()
		{
		Console.WriteLine("===============================================================");
		Console.WriteLine(" Uso de la App_Calcular para calcular el area, lon... bla, bla ");
		Console.WriteLine("===============================================================");
		Console.WriteLine(" SINTAXIS:	App_calcular [l/L] radio,         Para la longitud");
		Console.WriteLine("             App_calcular [a/A] radio,         Para el area");
		Console.WriteLine("             App_calcular [l/L] radio altura   Para la longitud");
		Console.WriteLine();
		Console.WriteLine("   App_Calcular ?     Para mostrar esta ayuda");
		}

		static double Longitud (double radio)
		{
			return 2 * Math.PI * radio;
		}

		static double Area (double radio)
		{
			return Math.PI * radio * radio;
		}

		static double Volumen (double radio, double altura)
		{
			return Math.PI * radio * radio * altura;
		}




		#endregion
	}
}
