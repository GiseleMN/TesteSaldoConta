using System;
using SaldoConta;

namespace TesteOperacoesxUnit
{
	public class ContaTestxUnit
	{
		[Fact]
		public void DepositoValorAtualizado()
		{
			//Arrange
			double saldoInicial = 20;
			double valorDepositado = 66.50;
			double valorEsperado = 86.50;
			var conta = new Conta(saldoInicial);

			//Act
			conta.Depositar(valorDepositado);

			//Assert
			double valorAtualizado = conta.Saldo;

			Assert.Equal(valorEsperado, valorAtualizado);
		}

		[Fact]
		public void DepositoValorInvalido_ComRetornoDeErro()
		{
			//Arrange
			double saldoInicial = 20;
			double valorDeposito = -8;
			var conta = new Conta(saldoInicial);

			Assert.Throws<ArgumentOutOfRangeException>(() => conta.Depositar(valorDeposito));
		}
	}
}

