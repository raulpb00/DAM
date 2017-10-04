using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string miNombre = "";

            Console.WriteLine("Me dices tu nombre y lo muestro");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.Write("    Por favor, dime tu nombre: ");
            miNombre = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("                       ------------------------------");
            Console.Write("                        Hola, te llamas ");
            Console.WriteLine(miNombre);
            Console.WriteLine("                       ------------------------------");


            Console.ReadLine();
        }
    }
}
