using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ContaBancaria
    {
        private int numero;
        
        private Cliente cliente;
        private Banco banco;

        public ContaBancaria(int numero, Cliente cliente, Banco banco)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.banco = banco;
        }

        public ContaBancaria(int numero, Cliente cliente)
        {
            this.numero = numero;
            this.cliente = cliente;
        }

        public void Depositar(double valor)
        {
            banco.Depositar(valor);
        }

        public void Sacar(double valor)
        {
            banco.Sacar(valor);
        }

        public void ExibirDados()
        {
            Console.WriteLine("Conta: " + numero);
            Console.WriteLine(cliente.ToString());
        }

        public override String ToString()
        {
            return "Conta: " + numero + ", " + cliente.ToString() + ", " + banco.ToString();
        }
    }
}