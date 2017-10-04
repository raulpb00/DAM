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
            Console.WriteLine("Hola soy el metodo que escribe");            //WriteLine salta de linea después de escribir.
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.Write("El valor de PI es: ");                           //Write sólo, deja el cursor después del texto.
            Console.WriteLine(3.141592);

            Console.ReadLine();        //Se queda esperando una entrada por teclado, recibe lo que le metas, pero no hace nada con ello.
        }
    }
}

