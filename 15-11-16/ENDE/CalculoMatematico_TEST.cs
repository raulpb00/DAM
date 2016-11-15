using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematicas;

namespace Matematicas_TEST
{
	[TestClass]
	public class CalculoMatematico_TEST
	{
		[TestMethod]
			//camino 1 : entrada: 1, esperando : false
		public void esPrimo_valor1_esFalso()
		{
			//Arrange
			uint numero = 1;
			bool resultado;
			//Act
			resultado = CalculoMatematico.EsPrimo(numero);
			//Assert
			Assert.IsFalse(resultado, "El numero dado es primo");
		}
		[TestMethod]
			//camino 2 : entrada: 2, esperando : true
		public void esPrimo_valor2_esTrue()
		{
			//Arrange
			uint numero = 2;
			bool resultado;
			//Act
			resultado = CalculoMatematico.EsPrimo(numero);
			//Assert
			Assert.IsTrue(resultado, "El numero dado no es primo");
		}
		[TestMethod]
			//camino 3 : entrada: cualquier numero PAR, esperando : false
		public void esPrimo_valorCualquierPAR_esFalso()
		{
			//Arrange
			uint numero1 = 4;
			uint numero2 = 4294967294;
			//Act
			
			//Assert
			Assert.IsFalse(CalculoMatematico.EsPrimo(numero1), "El numero dado es primo");
			Assert.IsFalse(CalculoMatematico.EsPrimo(numero2), "El numero dado es primo");
		}
		[TestMethod]
			//camino 5 : entrada: 5, esperando : true
		public void esPrimo_valor5_esTrue()
		{
			//Arrange
			uint numero = 5;
			bool resultado;
			//Act
			resultado = CalculoMatematico.EsPrimo(numero);
			//Assert
			Assert.IsTrue(resultado, "El numero dado no es primo");
		}
	}
}
