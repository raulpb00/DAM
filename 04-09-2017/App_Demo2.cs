using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Demo1                      //Espacio de Nombre 
{
    class Program                      //Clase
    {
        static void Main(string[] args)                //Función MAIN
        {
            string miNombre = "";                   //Declaro la variable miNombre y la inicializo con un string vacío "".

            Console.WriteLine("Me dices tu nombre y lo muestro");               //WriteLine salta de linea después de escribir.
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.Write("    Por favor, dime tu nombre: ");                   //Write sólo, deja el cursor después del texto.
            miNombre = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("                       ------------------------------");
            Console.Write("                        Hola, te llamas ");
            Console.WriteLine(miNombre);
            Console.WriteLine("                       ------------------------------");


            Console.ReadLine();        //Se queda esperando una entrada por teclado, recibe lo que le metas, pero no hace nada con ello.
        }
    }
}
