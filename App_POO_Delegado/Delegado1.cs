using System;

namespace APP_POO_Delegados
{
    class Program
    {
        // Declaro el tipo de dato delegado llamado MiDelegado
        public delegate void MiDelegado(string msg);

        static void Main(string[] args)
        {
            // Creo una instancia del tipo de delegado MiDelegado
            MiDelegado llamada = MetodoQueUsaElDelegado;

            llamada("Hola pishhha, soy la instancia del delegado");
            MetodoQueUsaElDelegado("Hola caracola, soy el método");
            llamada = MetodoQueUsaElDelegado1;

            MetodoConDevolucion("Texto recibido", llamada);

            Console.ReadLine();
        }

        static void MetodoQueUsaElDelegado(string msg)
        {
            Console.WriteLine(msg);
        }
        static void MetodoQueUsaElDelegado1(string msg)
        {
            Console.WriteLine("Soy el metodo 1");
        }
        static void MetodoConDevolucion(string texto, MiDelegado delegado)
        {
            delegado("-----------");
            Console.WriteLine(texto);
        }
    }
}
