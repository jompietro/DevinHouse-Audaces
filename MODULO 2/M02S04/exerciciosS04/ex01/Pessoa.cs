using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaSpace
{
    public class Pessoa
    {
        private string nome;
        protected string idade;
        public string endereco;

    public Pessoa(string nome, string idade, string endereco)
    {
      this.nome = nome;
      this.idade = idade;
      this.endereco = endereco;
    }

    public void saudacao(){
            Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos e moro na {endereco}!");
        }


    }
}