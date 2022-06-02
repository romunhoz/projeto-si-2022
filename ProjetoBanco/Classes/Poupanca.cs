﻿namespace ProjetoBanco.Classes
{
    public class Poupanca : Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo)
            : base(cliente, numero, saldo)
        { }

        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                MensagemTransacoes = $"Valor de depósito inválido!";
                return false;
            }

            Saldo += valorDeposito + 0.5m;
            MensagemTransacoes = "Deposito realizado com sucesso!";

            return true;
        }

        public override bool Sacar(decimal valorSaque)
        {
            if (Saldo <= 0m)
            {
                MensagemTransacoes = $"Saldo insuficiente para saque. Saldo atual: {Saldo}";
                return false;
            }

            if (Saldo < valorSaque)
            {
                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque} e o Saldo é {Saldo}";
                return false;
            }

            Saldo -= valorSaque + 0.1m;
            return true;
        }
    }
}