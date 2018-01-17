﻿using System;

namespace Raul.App_POO_GestionDePersonas
{
    class ObtenerPersonaAleatoria
    {
        static string[] nombres = { "Raul", "Bilal", "Fran", "Manuel", "Ignacio", "Eustaquio", "Eliseo", "Aitor", "Vyacheslav", "Ismael", "Sebas", "Ana", "Muzska", "Rubén", "Alejandro" };
        static string[] apellidos = { "Prieto", "Perez", "González", "Toro", "Roldán", "Moya", "Rivas", "Tilla", "Menta", "García", "Shylyayev", "Bueno", "Turbado", "Sánchez", "Zúñiga" };
        static Random rnd = new Random();

        public static Persona Crear()
        {
            Persona p = new Persona(CrearNombre(), CrearApellidos(), CrearFechaNacimiento(), CrearEstatura());
            return p;
        }

        // Método Privado
        static string CrearNombre()
        {
            return nombres[rnd.Next(nombres.Length)];
        }
        static string CrearApellidos()
        {
            return apellidos[rnd.Next(apellidos.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
        }
        static DateTime CrearFechaNacimiento()
        {
            // Últimos 20 años, aproximadamente
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }
        static double CrearEstatura()
        {
            // Crear estatura entre 1.50 y 2.10 aprox
            double estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }
    }
}
