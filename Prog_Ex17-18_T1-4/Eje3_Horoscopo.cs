using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Eje_3
{
    class Eje_3
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            DateTime fechaNac;
            string horoscopo = "";
            bool flag = false;

            Intro();
            do
            {
                try
                {
                    Console.WriteLine(" Tu Horóscopo.");
                    Console.Write(" Introduce tu Fecha de Nacimiento (Día/Mes): ");
                    fechaNac = DateTime.Parse(Console.ReadLine());
                    horoscopo = ComprobarHoroscopo(fechaNac);

                    if ( horoscopo != "" )
                        ImprimirHoroscopo(fechaNac, horoscopo);
                    else
                        Console.WriteLine(" Hay un error en la lectura del Horoscopo.");

                    Outro();
                    flag = true; // Evito que el programa acabe en caso de errores
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

        #region Funciones del Programa
        static string ObtenerMes(int mes)
        {
            if ( mes == 1 )
                return "Enero";
            else if ( mes == 2 )
                return "Febrero";
            else if ( mes == 3 )
                return "Marzo";
            else if ( mes == 4 )
                return "Abril";
            else if ( mes == 5 )
                return "Mayo";
            else if ( mes == 6 )
                return "Junio";
            else if ( mes == 7 )
                return "Julio";
            else if ( mes == 8 )
                return "Agosto";
            else if ( mes == 9 )
                return "Septiembre";
            else if ( mes == 10 )
                return "Octubre";
            else if ( mes == 11 )
                return "Noviembre";
            else if ( mes == 12 )
                return "Diciembre";
            else
                return "";
        }
        static void ImprimirHoroscopo(DateTime fechaNac, string horoscopo)
        {
            string mesNac = ObtenerMes(fechaNac.Month); // Obtengo el string del mes de nacimiento

            ConsoleColor colorL = Console.ForegroundColor;
            Console.Write(" Has nacido el día {0} de {1}.\n\t¡Eres ", fechaNac.Day, mesNac);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}", horoscopo);
            Console.ForegroundColor = colorL;
            Console.WriteLine("!");
        }
        static string ComprobarHoroscopo(DateTime fechaNac)
        {
            if ( ( fechaNac.Month == 1 && fechaNac.Day >= 20 ) || ( fechaNac.Month == 2 && fechaNac.Day <= 18 ) )
                return "Acuario";
            else if ( ( fechaNac.Month == 2 && fechaNac.Day >= 19 ) || ( fechaNac.Month == 3 && fechaNac.Day <= 20 ) )
                return "Piscis";
            else if ( ( fechaNac.Month == 3 && fechaNac.Day >= 21 ) || ( fechaNac.Month == 4 && fechaNac.Day <= 19 ) )
                return "Aries";
            else if ( ( fechaNac.Month == 4 && fechaNac.Day >= 20 ) || ( fechaNac.Month == 5 && fechaNac.Day <= 20 ) )
                return "Tauro";
            else if ( ( fechaNac.Month == 5 && fechaNac.Day >= 21 ) || ( fechaNac.Month == 6 && fechaNac.Day <= 20 ) )
                return "Géminis";
            else if ( ( fechaNac.Month == 6 && fechaNac.Day >= 21 ) || ( fechaNac.Month == 7 && fechaNac.Day <= 22 ) )
                return "Cáncer";
            else if ( ( fechaNac.Month == 7 && fechaNac.Day >= 23 ) || ( fechaNac.Month == 8 && fechaNac.Day <= 22 ) )
                return "Leo";
            else if ( ( fechaNac.Month == 8 && fechaNac.Day >= 23 ) || ( fechaNac.Month == 9 && fechaNac.Day <= 22 ) )
                return "Virgo";
            else if ( ( fechaNac.Month == 9 && fechaNac.Day >= 23 ) || ( fechaNac.Month == 10 && fechaNac.Day <= 22 ) )
                return "Libra";
            else if ( ( fechaNac.Month == 10 && fechaNac.Day >= 23 ) || ( fechaNac.Month == 11 && fechaNac.Day <= 21 ) )
                return "Escorpio";
            else if ( ( fechaNac.Month == 11 && fechaNac.Day >= 22 ) || ( fechaNac.Month == 12 && fechaNac.Day <= 21 ) )
                return "Sagitario";
            else if ( ( fechaNac.Month == 12 && fechaNac.Day >= 22 ) || ( fechaNac.Month == 1 && fechaNac.Day <= 19 ) )
                return "Capricornio";
            else
                return "";
        }
        static void Intro()
        {
            Console.Title = "Ej_3 Raúl Prieto";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
        }
        static void Outro()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop + 2);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Pulse ENTER para salir.");
            Console.ReadLine();
        }
        #endregion
    }
}
