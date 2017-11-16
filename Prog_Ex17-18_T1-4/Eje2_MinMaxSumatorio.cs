using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Eje_2
{
    class Eje_2
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            int min = 0;
            int max = 0;

            Intro();

            PedirValores(ref min, ref max);

            Console.WriteLine("\n La suma de los enteros entre \"{0}\" y \"{1}\" es:", min, max);
            Console.WriteLine(" Recursiva: {0}", SumaRecursiva(min, max));
            Console.WriteLine(" Iterativa: {0}", SumaIterativa(min, max));

            Outro();
        }

        #region Funciones del Programa
        static void PedirValores(ref int min, ref int max)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Calculo la suma de los numeros enteros comprendidos entre un minimo y un maximo dados.");

                try
                {
                    do
                    {

                        Console.Write(" Introduce un mínimo: ");
                        min = int.Parse(Console.ReadLine());
                        Console.Write(" Introduce un máximo: ");
                        max = int.Parse(Console.ReadLine());
                        if ( min > max )
                            Console.WriteLine("\tEl máximo no puede ser menor que el mínimo.");
                        if ( min < 0 || max < 0 )
                            Console.WriteLine("\tNingún valor puede ser negativo");
                    } while ( min > max || min < 0 || max < 0 ); // Compruebo los valores insertados

                    flag = true; // Controla que el try no ha lanzado excepción y ha terminado
                }
                catch ( Exception e )
                {
                    Console.SetCursorPosition(Console.CursorLeft + 10, ++Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: {0}", e.Message);
                    Thread.Sleep(1500);
                    Intro();
                }
            } while ( !flag );
        }
        static int SumaIterativa(int min, int max)
        {
            int suma = 0;

            for ( int i = min; i <= max; i++ )
            {
                suma += i;
            }

            return suma;
        }
        static int SumaRecursiva(int min, int max)
        {
            return ( max == min ) ? min : max + ( SumaRecursiva(min, max - 1) );
        }
        static void Intro()
        {
            Console.Title = "Ej_2 Raúl Prieto";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
        }
        static void Outro()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop + 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Pulse ENTER para salir.");
            Console.ReadLine();
        }
        #endregion
    }
}
