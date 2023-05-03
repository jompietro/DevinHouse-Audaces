using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        

            Cliente cliente = new Cliente("João Silva", "123.456.789-00");

            ContaBancaria conta = new ContaBancaria(123, cliente, new Banco());

            Console.WriteLine("Dados da conta: ");
            conta.ExibirDados();
            Console.WriteLine();

            Console.WriteLine("Depósito de R$1000.00");
            conta.Depositar(1000);
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.WriteLine("Saque de R$500.00");
            conta.Sacar(500);
            Console.WriteLine(conta.ToString());
            Console.WriteLine();
        }
    }
}