using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Banco
    {
        private double saldo;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public override string ToString()
        {
            return "Saldo: " + saldo;
        }
    }
}