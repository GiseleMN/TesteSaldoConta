using System;
namespace SaldoConta
{
	public class Conta
	{
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            // adicionando condicao para valor do deposito menor ou igual a zero
            if (valor <= 0)
            {
                throw new
                    ArgumentOutOfRangeException("Valor do depósito não pode ser menor ou igual a zero.");
            }
            Saldo += valor;
        }
    }
}

