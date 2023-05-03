using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public const decimal SaldoMaximo = 5000;

        private decimal Saldo { get; set; }


        public void Depositar(decimal valor)
        {
            if (valor > 0 && valor <= SaldoMaximo)
            {
                Saldo += valor;
                System.Console.WriteLine("Depósito realizado com sucesso!. Saldo atual de: " + Saldo);
            } else
            {
                System.Console.WriteLine("Valor inválido para depósito!");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && Saldo > valor)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso!. Saldo atual de: " + Saldo);
            } else
            {
                System.Console.WriteLine("Valor inválido para saque!");
            }
        }
    }
}