using System;
using SaldoConta;

namespace TesteOperacoes
{
	[TestClass]
	public class ContaTestMst
	{
		[TestMethod]
		public void Deposito_ComValor_AtualizarSAldo()
		{
			//Arrange -
			double saldoInicial = 20;
			double valorDepositado = 66.75;
			double valorEsperado = 86.75;
			var conta = new Conta(saldoInicial);

			//Act
			conta.Depositar(valorEsperado);

			//Assert
			//conta com valor atualizado 
			double valorAtualizado = conta.Saldo;
			//valor esperado(saldo + deposito)
			Assert.AreEqual(valorEsperado, valorAtualizado);
		}

		[TestMethod]
		public void DepositoComValorInvalido_RetornaErro()
		{
			//Arrange
			double saldoInicial = 20;
			double valorDepositado = -10;
			var conta = new Conta(saldoInicial);

			//Assert (retornar valor invalido, erro)
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Depositar(valorDepositado));
		}
	}
}

