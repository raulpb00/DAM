using System;

namespace Raul.App_Exp_lambda
{
    delegate int dlgCuadrado(int x);    

    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;

            // C# 1.0. Uso de delegados
            Console.WriteLine("\n -- C# 1.0: Uso de delegados ---");
            // Creo una instancia del delegado asignada a cuadrado()
            dlgCuadrado dc1 = new dlgCuadrado(Cuadrado);
            // Llamo al delegado y le paso un valor
            Console.WriteLine("\t{0}\n",dc1(numero).ToString());

            // C# 2.0. Delegados con código de inicializacion (met.Anonimo)
            Console.WriteLine("\n -- C# 2.0: Delegados con código de inicializacion (met.Anonimo) ---");
            dlgCuadrado dc2 = delegate(int x)
            {
                return x * x;
            };
            Console.WriteLine("\t{0}\n", dc2(numero).ToString());

            // C# 3.0. Delegados con expresion Lambda
            Console.WriteLine("\n -- C# 3.0: Delegados con expresion Lambda ---");
            dlgCuadrado dc3 = x => x * x;
            Console.WriteLine("\t{0}\n", dc3(numero).ToString());

            // C# 3.0. Delegados genéricos integrados con expresion Lambda
            Console.WriteLine("\n -- C# 3.0: Delegados genéricos integrados con expresion Lambda ---");
            Func<int, int> dc4 = x => x * x;            
            Console.WriteLine("\t{0}\n", dc4(numero).ToString());


            Console.ReadLine();
        }

        static int Cuadrado(int i)
        {
            return i * i;
        }
    }
}
