internal class Program
{
  private static void Main(string[] args)
  {

// -------------------CALCULADORA------------------vvvvvvvvvv


//     Variáveis

//     double numero1, numero2;
//     char operacao;

//     Console.WriteLine("Seja bem-vindo a calculadora! \n");

//     do
//     {
//         Console.WriteLine("Agora, escolha uma operação: \n");

//       Console.WriteLine("+ : SOMA");
//       Console.WriteLine("- : SUBTRAIR");
//       Console.WriteLine("* : MULTIPLICAR");
//       Console.WriteLine("/ : DIVIDIR");
//       Console.WriteLine("? : SAIR");

//       // Entradas 
//       Console.Write("\nDigite a operação escolhida: ");
//       operacao = char.Parse(Console.ReadLine());

//       if (operacao != '?')
//       {
//         Console.WriteLine("Digite o primeiro número: ");
//         numero1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite o segundo número: ");
//         numero2 = int.Parse(Console.ReadLine());

//             switch (operacao)
//           {
//             case '+':
//                 Console.WriteLine(numero1 + numero2);
//                 break;
//             case '-':
//                 Console.WriteLine(numero1 - numero2);
//                 break;
//             case '*':
//                 Console.WriteLine(numero1 * numero2);
//                 break;
//             case '/':
//                 Console.WriteLine(numero1 / numero2);
//                 break;
//             case '?':
//                 Console.WriteLine("Saindo");
//                 break;
//             default: 
//                 Console.WriteLine(Inválido);
//                 break;
//           }

//       }
//     } while (operacao != '?');

//     Console.WriteLine("\n Obrigado por usar a calculadora! ")

    




//     // Processamentos/operações

    


//     Saídas




//-------------------------------------------------------------------


    // EXEMPLO 1

    // // Variáveis
    // String? nome;
    // int idade;
    // // Mensagens instrucionais ao usuario 
    // Console.WriteLine("Olá mundo! Digite o seu nome: ");
    // // Entradas: inserção de dados
    // nome = Console.ReadLine(); 

    // Console.WriteLine("Ola " + nome + ", digite a sua idade: ");
    // idade = int.Parse (Console.ReadLine());
    // // Processamentos: calculos, regras de negocios...
    // // Saída: mostrar o resultado em tela.
    
    // Console.WriteLine("Olá " + nome + ", a sua idade é " + idade);



    // EXEMPLO 2, operadores

    // int numero1 = 10;
    // int numero2 = 15;

    // int soma = numero1 + numero2;
    // int subtracao = numero1 - numero2;
    // int multiplicacao = numero1 * numero2;
    // double divisao = numero1 / numero2;
    // int restoDaDivisao = numero1 % numero2;

    // Console.WriteLine(soma);
    // Console.WriteLine(subtracao);
    // Console.WriteLine(multiplicacao);
    // Console.WriteLine(divisao);
    // Console.WriteLine(restoDaDivisao);

    //EXEMPLO 3 

    // Console.WriteLine("Digite o primeiro numero: ");
    // int numero1 = int.Parse(Console.ReadLine());

    // Console.WriteLine("Digite o primeiro numero: ");
    // int numero2 = int.Parse(Console.ReadLine());


    // int soma = numero1 + numero2;

    // Console.WriteLine("A soma dos numeros é: " + soma);


    //EXEMPLO 4 

    // Console.WriteLine(1 == 2);

    // EXEMPLO 6

    // Console.WriteLine("Digite um número para verificar se ele é ímpar ou par: ");
    // int numero = int.Parse(Console.ReadLine());

    // if (numero % 2 == 0)
    // {
    //   Console.WriteLine("O número é par!");
    // }
    // else
    // {
    //   Console.WriteLine("O número é impar!");
      
    // }


//-----------------------------------------------------------------------------

// EXERCíCIO 1

//     int numero1, numero2, soma; 

//     Console.Write("Digite o primeiro número: ");
//     numero1 = int.Parse(Console.ReadLine());

//     Console.Write("Digite o segundo número: ");
//     numero2 = int.Parse(Console.ReadLine());

//     soma = numero1 + numero2;

//     Console.WriteLine($"A soma dos números é: {soma}");

//     EXERCÍCIO 2 

//     int numero;

//     Console.WriteLine("Digite um número inteiro: ");
//     numero = int.Parse(Console.ReadLine());

//     if (numero % 2 == 0)
//     {
//       Console.WriteLine("O número é par.")
//     } else
//     {
//       Console.WriteLine("O número é ímpar.")
//     }

//     EXERCÍCIO 3

//     string nome;
//     int idade;

//     Console.WriteLine("Digite o nome do paciente: ");
//     nome = Console.ReadLine();

//     Console.WriteLine("Digite a idade do paciente: ");
//     idade = int.Parse(Console.ReadLine());

//     Console.WriteLine($"O nome do paciente é {nome}");

//     if (idade < 18)
//     {
//       Console.WriteLine("O paciente é menor de idade");
//     } else if (idade >= 60)
//     {
//       Console.WriteLine("O paciente é idoso");
//     } else
//     {
//       Console.WriteLine("O paciente é maior de idade");
//     }

    
//      EXERCÍCIO 4 


//      string marca, modelo;
//      double km;

//      Console.Write("Digite a marca do carro: ");
//      marca = Console.ReadLine();

//      Console.Write("Digite o modelo do carro: ");
//      modelo = Console.ReadLine();

//      Console.Write("Digite a quilometragem do carro: ");
//      km = double.Parse(Console.ReadLine());

//     Console.WriteLine($"\n- Marca do carro: {marca}\n- Modelo do carro: {modelo}\n- Quilometragem rodada: {km}");

//     if(km > 10000)
//     {
//       Console.WriteLine("É necessário fazer uma revisão."); 
//     }


// EXERCICIO 5

  // int [] numeros = new int[4];

  // for (int i = 0; i < numeros.length; i++)
  // {
  //   Console.WriteLine("Digite um numero inteiro: ");
  //   numeros[i] = Convert.ToInt32(Console.ReadLine());
  // }

  // Array.Sort(numeros);

  // foreach (var item in numeros)
  // {
  //   Console.WriteLine($"{item}");
  // }

  //EXERCICIO 6

  // string frase = "A linguagem de programaçao c# é muito poderosa";
  // List<string> palavra = new List<string>(frase.Split(' '));


  // foreach (var item in palavra)
  // {
  //   if (item == "poderosa") {
  //     Console.WriteLine(item);
  //   }
  // }


  //EXERCICIO 7

// int numero;

//       do {
//         Console.Write("Digite um número inteiro: ");
//         numero = int.Parse(Console.ReadLine());

//         if (numero <= 0) {
//             Console.WriteLine("Erro! o número deve ser positivo e diferente de zero.");
//         }
//       } while (numero <= 0);

//       Console.WriteLine($"Números pares até {numero}:");

//       for (int i = 0; i <= numero; i += 2){
//         Console.Write(i + " ");
//       }


    //EXERCICIO 8 

    // int[] numeros = new int[5];

    // for (int i = 0; i < numeros.Length; i++)
    // {
    //   Console.Write("Digite um numero inteiro: ");
    //   numeros[i] = Convert.ToInt32(Console.ReadLine());
    // }

    
    // Console.WriteLine(numeros.Max());


    //EXERCICIO 9

    // Console.Write("Qual a quantidade de números que você deseja fazer a média: ");
    // int quantidade = int.Parse(Console.ReadLine());

    // int[] numeros = new int [quantidade];

    // int soma = 0;
    // double media;
    // int[] numeros = new int[quantidade];

    // for(int i = 0; i< quantidade; i++ ) 
    // {
    //   Console.Write($"Digite o {i + 1}ºnumero: ");
    //   numeros[i] = int.Parse(Console.ReadLine());
    // }

    // int soma = 0;



    // foreach (int numero in numeros)
    // {
    //   soma += item;
    // }

    // media = soma / quantidade;



  }

} 