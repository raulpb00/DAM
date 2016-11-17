using System;

namespace App_Estructuras
{
	class Uso_Estructuras
	{
		public const double IVA = 21.33; // Declaración de constante visible a otros ámbitos 
		const double VALOR = 12.33 * IVA; //Declaración de constante usando otra constante


		struct FichaPersona 
		{
			/*public*/	string nombre;
			float altura;
			int edad; // etc
			
			//Leer datos
			public FichaPersona(string n, float a, int e)
			{
				nombre = n;
				if (a>2.50F) 
					a = 2.50F;
				altura = a;
				if (e > 120)
					e = 120;
				if (e < 18)
					e = 18;
				edad = e;
			}
			public string GetNombre()
			{
				return nombre;
			}
			public float GetAltura()
			{
				return altura;
			}
			public int GetEdad()
			{
				return edad;
			}

			//Escribir datos
			public void SetNombre(string n)
			{
				nombre = n;
			}
			public float SetAltura(float a)
			{
				if (a>2.50F) a = 2.50F;
				altura = a;
				return a;
			}
			public int SetEdad(int e)
			{
				if (e > 120)
					e = 120;
				if (e < 18)
					e = 18;
				edad = e;
				return e;
			}

			//Obtener todos los datos de una persona
			public string GetPersona()
			{
				return nombre+", "+altura.ToString()+" m, "+edad.ToString()+" años.";
			}
			public override string ToString()
			{
				
				return nombre+", "+altura.ToString()+" m, "+edad.ToString()+" años.";
			}
		}
		static void Main(string[] args)
		{
			Inicio();
			FichaPersona alumno1 = new FichaPersona();
			FichaPersona alumno2 = new FichaPersona("Anita", 1.68F, 20);

			Console.Write("Introduce el nombre de Alumno1: ");
			alumno1.SetNombre(Console.ReadLine());
			Console.Write("Introduce la altura de Alumno1: ");
			alumno1.SetAltura(float.Parse(Console.ReadLine()));
			Console.Write("Introduce la edad de Alumno1: ");
			alumno1.SetEdad(int.Parse(Console.ReadLine()));

			Console.WriteLine("\nDatos del alumno1 con .GetPersona: "+alumno1.GetPersona());
			Console.WriteLine("Datos del alumno1 con .ToString: "+alumno1.ToString());
			Console.WriteLine("\nDatos del alumno2:\nNombre. "+alumno2.GetNombre()+"\nAltura. "+alumno2.GetAltura()+" m\nEdad. "+alumno2.GetEdad()+" años"); 


		/*	alumno1.nombre = "Pepito";
			alumno2.nombre = "Anita";
			Console.WriteLine("El nombre del alumno1 es {0}.", alumno1.nombre); */
			Console.ReadLine();
		}

		static void Inicio()
		{
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			Console.WriteLine("\t\t\t.-USO DE LAS STRUCT-.\n\n");
		}
	}
}
