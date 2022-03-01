namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, sou professor de salário {Salario} e tenho {Idade} anos");
        }

    }
}