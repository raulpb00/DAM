using System;

namespace Raul.App_Exp_lambda
{
    delegate int MiDelegado(int i);    

    class Program
    {
        static void Main(string[] args)
        {
            int j;
            MiDelegado _delegado = x => x * x;
            //MiDelegado _delegado = Cuadrado;
            j = _delegado(10);
            Console.WriteLine(j);

            Console.ReadLine();
        }

        static int Cuadrado(int i)
        {
            return i * i;
        }
    }
}

/*
 *  (x, y) => x==y;
 *  (int x, string s) => s.length > x;
 *  () => algunMetodo();
 *  _delegado miDel = n => {
 *  
 * 
 *                          }
 * 
 */
