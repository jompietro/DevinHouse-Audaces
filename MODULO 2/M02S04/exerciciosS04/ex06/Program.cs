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
            Retangulo retangulo = new Retangulo();

            retangulo.Largura = 2;
            retangulo.Altura = 10;

            // Calcular e imprimir a área do retângulo
            double area = retangulo.CalcularArea();

            System.Console.WriteLine($"Área do retângulo: {area}");
        }
    }
}