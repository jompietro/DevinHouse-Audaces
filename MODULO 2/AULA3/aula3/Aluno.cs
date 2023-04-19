//Atenção ao Namespace da classe, pois ele deve ser referenciado como using quando quiser estaciar a classe, 
//ou utilizar Namespace.Class para conseguir endereção a classe que vc esta estaciando. EX. Classes.Aluno
namespace Classes
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Matricula {get; set;}
        public string Endereco {get; set;}
        public string Telefone {get; set;}

        public Boletim Boletim { get; set; }

        public void RealizarMatricula(){
            //Faça a Matricula
            Matricula= new Random().Next();
            Console.WriteLine($"Matricula de {Nome} realizada {Matricula}");
        }
        public void ConsultarNotas(){
            Console.WriteLine(Boletim.ObterDescritivoNotas());
            Console.WriteLine("Com média: "+ Boletim.Media());
        }
    }
}