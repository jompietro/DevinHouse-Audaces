using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancariaSpace
{
    public class ContaBancaria
    {
        private string NumeroConta;
        private double Saldo;

    public ContaBancaria(string numeroConta)
    {
      NumeroConta = numeroConta;
        Saldo = 0;
    }

    public void Deposita(double valor){
            Saldo += valor;
        }
        public void Saca(double valor){
            Saldo -= valor;
            
        }
        public double getSaldo(){
            return Saldo;
        }
    }
}