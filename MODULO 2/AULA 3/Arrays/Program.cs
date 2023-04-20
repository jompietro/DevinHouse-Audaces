
// int [] num = new int[3];

// num[0] = 1;
// num[1] = 6;
// num[2] = 8;

// Console.WriteLine($"Posição 0 : " +  num[0]);
// Console.WriteLine($"Posição 1 : " +  num[1]);
// Console.WriteLine($"Posição 2 : " +  num[2]);

// int tamanhoArray = 2;

// string[] nomes = new string[tamanhoArray];

// for(int i = 0; i< tamanhoArray; i++){
//   Console.WriteLine($"Digite o {i} nome:");
//   nomes[i] = Console.ReadLine();
// }

// foreach (var nome in nomes)
// {
//   Console.WriteLine(nome);
// }



//---------------------------------


List<string> lista = new List<string>();
lista.Add("Ovo");
lista.Add("Leite");
lista.Add("Cafe");
lista.Add("Pao");
lista.Add("Agua");
lista.Add("Bolacha");

lista.Remove("Cafe");

for(int i = 0; i< lista.Count; i++){
  Console.WriteLine(lista[i]);
}




