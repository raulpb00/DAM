using System;

namespace Raul.App_POO_GestionDePersonas
{
    class Persona
    {
        #region // Campos
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private double _estatura;
        #endregion

        #region // Constructores
        public Persona()
        {
            // Creo el constructor con datos vacíos
            this._nombre = "IES";
            this._apellidos = "Portada Alta";
            this._fechaNacimiento = DateTime.Parse("01/01/2000");
            this._estatura = 0.0;
        }
        public Persona(string nombre, string apellidos, DateTime fNac, double estatura)
        {
            // Creo el constructor con datos vacíos
            _nombre = nombre;
            _apellidos = apellidos;
            _fechaNacimiento = fNac;
            _estatura = estatura;
        }
        #endregion

        #region // Propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public double Estatura
        {
            get { return _estatura; }
            set { _estatura = value; }
        }
        #endregion

        #region // Métodos
        public override string ToString()
        {
            return " |" + _id.ToString().PadLeft(6, ' ') + " | " +
                _apellidos.PadRight(30) + " | " + _nombre.PadRight(15) + " | " +
                _fechaNacimiento.ToShortDateString() + " | ";
        }

        #endregion
    }
}
