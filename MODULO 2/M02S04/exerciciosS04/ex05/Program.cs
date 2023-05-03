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
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "João";
            pessoa1.DefinirIdade(18);

            System.Console.WriteLine($"Nome: {pessoa1.Nome}");
            System.Console.WriteLine($"Idade: {pessoa1.Idade}");
        }
    }
}