using System;
using System.Collections.Generic;

namespace Raul.App_POO_GestionDePersonas
{
    class ListaDePersonas
    {
        List<Persona> _personas = null;
        int _id = 100;


        public ListaDePersonas()
        {
            _personas = new List<Persona>();
        }

        public bool Anadir(Persona p)
        {
            p.Id = _id++;
            _personas.Add(p);
            return true;
        }

        public bool AnadirPersonaAleatoria()
        {
            Persona p = ObtenerPersonaAleatoria.Crear();
            p.Id = _id++;
            _personas.Add(p);
            return true;
        }

        public bool AnadirPersonasAleatorias(int nPersonas)
        {
            for (int i = 0; i < nPersonas; i++)
            {
                Persona p = ObtenerPersonaAleatoria.Crear();
                p.Id = _id++;
                _personas.Add(p);
            }

            return true;
        }

        public void Listar(string mensaje)
        {
            int anchoListado = 75;
            Console.CursorLeft = (anchoListado / 2) - (mensaje.Length / 2);
            Console.WriteLine(mensaje);
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona pTmp in _personas)
                Console.WriteLine(pTmp.ToString());
            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine("  No hay más personas a listar...");
        }

        public int Cuantos
        {
            get { return _personas.Count; }
        }
    }
}
