using System;
using SaldoConta;

namespace TesteOperacoes
{
	[TestClass]
	public class OperacoesTesteMst
	{
		[TestMethod]
		public void SomarDoisNumeros_RetornarResultado()
		{
			//Arrange  
			double numb1 = 10;
			double numb2 = 20;

			//Act
			var resultado = Operacoes.Somar(numb1, numb2);

			//Assert
			Assert.AreEqual(30, resultado);
		}
	}
}

