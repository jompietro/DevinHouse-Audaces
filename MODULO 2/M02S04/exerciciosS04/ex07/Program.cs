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
            ContaBancaria conta = new ContaBancaria();

            conta.NumeroConta = 123;
            conta.Depositar(1000);
            conta.Sacar(500);
            conta.Depositar(6000);
            conta.Sacar(4000);
        }
    }
}