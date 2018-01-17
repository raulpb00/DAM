using System;

namespace Raul.App_POO_GestionDePersonas
{
    class Principal
    {
        static void Main(string[] args)
        {
            ListaDePersonas Bomberos = new ListaDePersonas();
            Bomberos.AnadirPersonaAleatoria();
            Bomberos.AnadirPersonasAleatorias(150);
            Bomberos.Anadir(new Persona("Pepe", "Gil Garcia", DateTime.Parse("01/01/1995"), 1.95));
            Bomberos.Listar("Listado de Bomberos de Málaga");
            Console.WriteLine("\n\tHay {0} personas.", Bomberos.Cuantos);
            // Console.WriteLine(Bomberos[3]);
            Console.ReadLine();
        }
    }
}
