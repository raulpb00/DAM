using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Me dices dos numeros y te muestro la suma");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.Write("    Por favor, dime el primer numero:  ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("    Por favor, dime el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
    
            Console.WriteLine();
            Console.WriteLine("                       ------------------------------");
            Console.Write("                        La suma de ");
            Console.Write(numero1);
            Console.Write(" Y ");
            Console.Write(numero2);
            Console.Write(" es ");
            Console.WriteLine(numero1 + numero2);
            Console.WriteLine("                       ------------------------------");
          
            /*
             * Comentario
             * Largo
             */

            Console.WriteLine();
            Console.WriteLine("                       ------------------------------");
            Console.WriteLine("                        La suma es:    {0} + {1} = {2}",numero1,numero2,numero1+numero2);
            Console.WriteLine("                       ------------------------------");


            Console.ReadLine();     //Este comando sirve para terminar el programa manualmente.
        }
    }
}
