using System;

namespace Matematicas
{
	public class FaltanParametrosException : Exception { }
	public class DemasiadosParametrosException : Exception { }
	public class NoNumeroException : Exception { }
	public class FueraDeRangoException : Exception { }
	public class NumeroNoPositivoException : Exception { }




	class CalculoMatematico
	{
		static bool EsPrimo(string[] argumentos)
		{
			if (argumentos.Length == 0) //no se han pasado argumentos de entrada
				throw new FaltanParametrosException();
			else if (argumentos.Length > 1)
				throw new DemasiadosParametrosException();
			else 
			{
				try
				{
					int num = int.Parse(argumentos[0]);
					if (num<=0)
						throw new NumeroNoPositivoException();
					else
					{
						if (num == 1) 
							return false;
						for (int i = 2; i < num; i++)
						{
							if (num%i == 0)
								return false;
						}
					}
					
				}
				catch (FormatException)
				{
					throw new NoNumeroException();
				}
				catch (OverflowException)	
				{
					throw new FueraDeRangoException();
				}	
				
			}
			return true;
		}
		public static bool EsPrimo (int numero)
		{
			bool encontradoDivisor = false;

			if (numero < 2)
			{
				encontradoDivisor=true;
			}
			else
			{			
				//int i = 2;
				for (int i = 2; i < numero; i++)
				//while (!encontradoDivisor && (i < (numero / 2) +1))
				{
					if (numero%i==0)
					{
						encontradoDivisor=true;
					}
					//i++;
				}			
			}		
			return !encontradoDivisor;
		}
		
		
		
		static void Main(string[] args)
		{
			//Console.WriteLine("Hola {0} desde el Main de MATEMÁTICAS", args[0]);
			//Console.WriteLine(EsPrimo(2));

		Console.ReadLine();

		}
	}
}
