using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora //calculadora implementa a interface
    {

        //pegou os metodos que a caculculadora nao tinha e colocou os da interface para implementar clicando em CTRL + . e "implementar a interface"

        // public int Dividir(int num1, int num2) 
        // {
        //     return num1 / num2;
         
        // } //pode nao ser colocada pois tem uma implementação padrao na interface ICalculadora. 

        public int Multiplicar(int num1, int num2)
        {
           return num1 * num2;
        }

        public int Somar(int num1, int num2){
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3){
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}