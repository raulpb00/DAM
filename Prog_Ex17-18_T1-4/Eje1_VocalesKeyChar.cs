using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Eje_1
{
    class Eje_1
    {
        static void Main(string[] args)
        {
            // Declaro las variables 
            ConsoleKeyInfo tecla;
            int pulsaciones = 0;
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;

            Intro();

            try
            {
                Console.Write(" Leo caracteres e imprimo el numero de pulsaciones para cada vocal y el total de pulsaciones recibidas.\n\tPara finalizar, pulse \"*\".\n\n  ");

                do
                {
                    tecla = Console.ReadKey();
                    if ( tecla.KeyChar != '*' )
                        pulsaciones++;
                    ComprobarTecla(tecla, ref a, ref e, ref i, ref o, ref u);
                } while ( tecla.KeyChar != '*' );

                ImprimirFinal(a, e, i, o, u, pulsaciones);

                Outro();
            }
            catch ( Exception ex )
            {
                Console.SetCursorPosition(Console.CursorLeft + 10, ++Console.CursorTop);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: {0}", ex.Message);
            }
        }
        #region Funciones del Programa
        static void ComprobarTecla(ConsoleKeyInfo tecla, ref int a, ref int e, ref int i, ref int o, ref int u)
        {
            if ( tecla.Key == ConsoleKey.A )
                a++;
            if ( tecla.Key == ConsoleKey.E )
                e++;
            if ( tecla.Key == ConsoleKey.I )
                i++;
            if ( tecla.Key == ConsoleKey.O )
                o++;
            if ( tecla.Key == ConsoleKey.U )
                u++;
        }
        static void ImprimirFinal(int a, int e, int i, int o, int u, int pulsaciones)
        {
            Console.Write("\n\n a");
            ImprimirResultado(a);

            Console.Write("\n e");
            ImprimirResultado(e);

            Console.Write("\n i");
            ImprimirResultado(i);

            Console.Write("\n o");
            ImprimirResultado(o);

            Console.Write("\n u");
            ImprimirResultado(u);

            Console.WriteLine("\n\n El total de caracteres es: {0}", pulsaciones);
        }
        static void ImprimirResultado(int vocal)
        {
            Console.Write("[{0}] -> ", vocal);
            for ( int i = 0; i < vocal; i++ )
            {
                Console.Write("#");
            }
        }
        static void Intro()
        {
            Console.Title = "Ej_1 Raúl Prieto";
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
