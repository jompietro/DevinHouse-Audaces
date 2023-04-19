//Importando o Namespace de Classes para conseguir chamar a classe aluno
using Classes;


Aluno aluno = new Aluno();
aluno.Nome = "Vitor" ;
aluno.Matricula = 5;
aluno.Telefone = "123";
aluno.Endereco = "Rua Girassól";

Boletim boletim = new Boletim();
boletim.Nota1 = 5;
boletim.Nota2 = 6;
boletim.Nota3 = 8;

aluno.Boletim = boletim;

Console.WriteLine("Nota 1 do aluno " +  aluno.Boletim.Nota1);
//Variaveis enviadas por parameytros podem ser enviadas de duas maneiras
//By Value - Ocorre para variaveis primitivas Int, Long , Double etc.
//By Pass - Ocorre Para variaveis complexars Objetos classes.
int nota1 = 4;
Boletim boletim1 = new Boletim(){
  Nota1 = nota1,
  Nota2 = 6,
  Nota3 = 8
};
//Alteração pós envio para evidenciar que quando enviamos by value (Por valor) não replica no que ocorreu antes 
nota1 = 10;


var aluno1 = new Aluno(){
    Nome= "Antonio", 
    Matricula = 5, 
    Boletim = boletim1,
    Telefone = "456", 
    Endereco = "Rua Girassol"  
};
//Alteração pós envio para evidenciar que quando enviamos by Reference (Por Refeência)  replica no que ocorreu antes 
boletim1.Nota2 = 9;

aluno1.RealizarMatricula();
aluno1.ConsultarNotas();
aluno.RealizarMatricula();
aluno.ConsultarNotas();
