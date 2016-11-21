/*--------------------------------------------------------------------------------------
 * PROGRAMA:    Ejercicio 2, Examen Programación
 * AUTOR: 		Raúl Prieto Bailón
 * FUNCION: 	Usando funciones recursivas e iterativas, suma los numeros enteros
 * comprendidos entre un minimo y un maximo, incluyendo ambos.
 * FECHA 		21/11/2016	Versión 0.1
 * COMENTARIOS: --------
 * ---------------------------------------------------------------------------------*/
using System;

namespace Eje_2
{
	class Ejercicio2
	{
		static void Main(string[] args)
		{
			// Declaro las variables
			int numMin = 0;
			int numMax = 0;
			int resultadoIterativo = 0;
			int resultadoRecursivo = 0;
			//Intro del programa
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			try
			{
				do{
					Console.Write("Introduce un entero que haga de mínimo: ");
					numMin = int.Parse(Console.ReadLine());
					Console.Write("Introduce un entero que haga de máximo: ");
					numMax = int.Parse(Console.ReadLine());
				}while (numMax<numMin);

				resultadoIterativo = SumaIterativa (numMin, numMax);
				resultadoRecursivo = SumaRecursiva (numMin, numMax, resultadoRecursivo);

				ImprimirResultados(numMin,numMax,resultadoIterativo,resultadoRecursivo);				
			}
			catch 
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\n\tERROR: introduccion incorrecta. Reinicie el programa.");
			}
			Console.ReadLine(); //Evitamos que el programa finalice automáticamente			
		}

		#region Funciones del programa
		static int SumaIterativa (int min, int max)
		{
			int result = 0;

			for (int i = min; i <= max; i++)
			{
				result+=i;
			}

			return result;
		}
		static int SumaRecursiva (int min, int max, int res)
		{
			return (max==min) ? res+max : res+max+SumaRecursiva(min,max-1,res);			
		}
		static void ImprimirResultados (int min, int max, int resIt, int resRec)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("\nResultado calculado con funcion recursiva-.");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\tLa suma de los enteros \"{0}\" y \"{1}\" es: {2}",min, max, resRec);
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("\nResultado calculado con funcion iterativa-.");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\tLa suma de los enteros \"{0}\" y \"{1}\" es: {2}",min, max, resIt);
		}
		#endregion
	}
}
