using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();

            //valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);

            System.Console.WriteLine($"Área: {r.ObterArea()}");

            //valores inválidos
            Retangulo r2 = new Retangulo();
            r.DefinirMedidas(0,0);

            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            Aluno al = new Aluno();
            al.Nome = "Renata";
            al.Idade = 19;
            al.Apresentar();
            al.Nota = 7;

            Professor prof = new Professor();
            prof.Nome = "Ricardo";
            prof.Idade = 30;
            prof.Apresentar();
            prof.Salario = 2000;
            System.Console.WriteLine($"Salário: {prof.Salario}");

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10, 10));

            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();

            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Dividir(4,2)); //2
            System.Console.WriteLine(calc.Multiplicar(4,2));//8
            System.Console.WriteLine(calc.Somar(4,2)); //6
            System.Console.WriteLine(calc.Subtrair(4,2)); //2

            var caminho = "D:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta1");
                                            //criando duas pastas dentro da variavel caminho que ja estava definida
            FileHelper helper = new FileHelper();
            //listar diretorios
            helper.ListarDiretorios(caminho);
            //listar arquivos dos diretorios   
            helper.ListarArquivosDiretorios(caminho);

            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //criar diretorio
            //helper.CriarDiretorio(caminhoPathCombine);

            //apagar diretorio
            //helper.ApagarDiretorio(caminhoPathCombine, true); //passando true porque o segundo parametro do metodo deletar recebe um true ou false, um booleano, onde true apaga o diretorio e os arquivos dentro

            //criar arquivo de texto
            var caminhoArquivo = Path.Combine(caminho, "arquivo-de-texto.txt");
            
            // helper.CreateTextFile(caminhoArquivo, "teste de criação");

            //criar arquivo de texto com stream 
            //var listaString = new List<string> ("Linha 1", "Linha 2", "Linha 3");
            //helper.CreateTextFileStream(caminhoArquivo, listaString);

            //adicionar novas linhas
            // var listaStringContinuacao = new List<string> ("Linha 4", "Linha 5", "Linha 6");
            // helper.CreateTextFileStream(caminhoArquivo, listaStringContinuacao);

            // helper.LerArquivo(caminhoArquivo);
            // var novoCaminhoArquivo = Path.Combine(caminho, "Pasta2", "arquivo-de-texto.txt");
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);

            //copiar arquivo
            // var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-de-texto.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-de-texto-backup.txt");
            // helper.CopiarArquivos(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            //deletar arquivo
            helper.DeletarArquivos(caminhoArquivoTesteCopia);

        }
    }
}