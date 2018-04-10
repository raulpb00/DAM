using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
using Raul.Menu;

namespace catalogo2018_consola
{
    class ui
    {
        static DAOMySQL dao;
        static string host = "localhost";
        static string bd = "catalogo";
        static string usr = "usr_catalogo";
        static string pwd = "1234";
        static string port = "3306";

        public ui()
        {
            dao = new DAOMySQL();
            PedirOpcion();
        }

        static void Menu()
        {
            string[] opciones = {" [0] Conectar a la BD"," [1] Desconectar a la BD"," [2] ¿Hay conexión?"," [S] Fin del programa"};
            MenuPrincipal menu = new MenuPrincipal("CATALOGO de DVDs", opciones, 555, 555, true, ConsoleColor.Cyan);
            menu.MostrarMenu();
        }

        static void PedirOpcion()
        {
            ConsoleKeyInfo opcion;
            Menu();
            opcion = Console.ReadKey();
            Console.SetCursorPosition(1, Console.CursorTop + 3);

            try
            {
                switch (opcion.KeyChar)
                {
                    case '0': // Conexion a la BD
                        if (!dao.Conectado())
                        {
                            if (dao.Conectar(host, port, bd, usr, pwd))
                                Console.WriteLine("Conexión con éxito a la bd {0}", bd);
                        }
                        else
                            Console.WriteLine("Ya hay una conexión establecida");
                        break;
                    case '1': //Desconexión 
                        if (dao.Conectado())
                        {
                            dao.Desconectar();
                            Console.WriteLine("Desconexión con éxito de la bd {0}",bd);
                        }
                        else
                            Console.WriteLine("No hay conexión activa a la bd");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error: " + e.Message);
            }
        }

    }
}
