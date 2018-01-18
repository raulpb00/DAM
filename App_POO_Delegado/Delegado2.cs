using System;

namespace APP_POO_Delegados
{
    class Program
    {
        // Declaro el tipo de dato delegado llamado MiDelegado
        public delegate void MiDelegado();

        static void Main(string[] args)
        {
            // Creo una instancia del tipo de delegado MiDelegado
            MiDelegado delegado = M1;
            delegado += M2;
            delegado += M3;
            delegado();     // M1,M2,M3
            delegado -= M2; // M1,M3
            delegado();

            Console.WriteLine("Hay {0} métodos en la lista.", delegado.GetInvocationList().GetLength(0));

            Console.ReadLine();
        }
        static void M1()
        {
            Console.WriteLine("Soy M1()");
        }
        static void M2() // Sin sobrecarga
        {
            Console.WriteLine("Soy M2()");
        }
        static void M2(string m) // Con sobrecarga
        {
            Console.WriteLine("Soy M2()");
        }
        static void M3()
        {
            Console.WriteLine("Soy M3()");
        }
    }
}
