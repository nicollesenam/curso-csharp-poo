namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //aluno herdando/extends a classe Pessoa
    {
        public float Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, sou aluno nota {Nota} e tenho {Idade} anos");
        }

    }

    
}