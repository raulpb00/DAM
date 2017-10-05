using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace App_ClaseConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;    //Cambia el color de fondo al escribir a Azul cian oscuro.
            Console.ForegroundColor = ConsoleColor.White;   //Cambia el color de la letra al escribir a blanco.
            
            Console.Clear();            //Este metodo limpia/colorea toda la consola con el color actual

            Console.SetCursorPosition(6,2);         //Cambia el cursor a la posición x,y  6,2
            Console.WriteLine("Uso de los miembros de la clase Console");


            Console.ReadLine();
        }
    }
}
