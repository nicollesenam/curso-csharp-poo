namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, sou diretor de salário {Salario} e tenho {Idade} anos");
        }
    }
}