using System;

namespace App_Arrays
{
	class Uso_Arrays
	{
		static void Main(string[] args)
		{
			Inicio();
			Console.WriteLine("Int ocupa {0} bytes.",sizeof(int));

			const int LONGITUD = 10;
			//tipo[] nombre;
			int[] enteros1;
			enteros1 = new int[LONGITUD];

			int[] enteros2 = new int[LONGITUD];

			int[] enteros3 = {1, 4, 77};   //int[3]

			Console.ReadLine();
		}
		static void Inicio()
		{
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			Console.WriteLine("\t\t\t.-USO DE LOS ARRAYS-.\n");
		}
	}
}
