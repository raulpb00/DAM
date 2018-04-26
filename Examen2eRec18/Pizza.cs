namespace Examen2eRec18
{	
	public class Pizza
	{
		static int _PizzasPedidas = 0;	
		static int _PizzasServidas = 0;
		public enum Tamano { Pequeña, Mediana, Familiar };
		public enum Tipo { Margarita, Cuatro_Quesos, Funghi, Especial };

		Tamano _tamano;
		Tipo _tipo;
		bool _servida;

		public Pizza(Tamano tamano, Tipo tipo)
		{
			_tamano = tamano;
			_tipo = tipo;
			_servida = false;
			_PizzasPedidas++; // Bool de pedida innecesario, siempre estará pedida
		}		

		public static int PizzasServidas
		{
			get { return Pizza._PizzasServidas; }
			set { Pizza._PizzasServidas = value; }
		}
		public static int PizzasPedidas
		{
			get { return Pizza._PizzasPedidas; }
			set { Pizza._PizzasPedidas = value; }
		}

		public string Servir()
		{
			if (this._servida == true)
				return "Esta pizza ya estaba Servida";
			else
			{
				PizzasServidas++;
				this._servida = true;
				return "Sirviendo Pizza...";
			}
		}

		public override string ToString()
		{
			return string.Format("Pizza: {0} {1}, {2}", _tipo, _tamano, _servida ? "Servida" : "Pedida"); ;
		}

	}
}
