using System.IO;
using System.Collections.Generic;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        //list directories
        public void ListarDiretorios(string caminho){              // * return all 
           var retornoCaminho =  Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
                                 //method that returns an array of strings  //method to search all directories
            foreach(var retorno in retornoCaminho){
                System.Console.WriteLine(retorno);
            }

        }
        //list files in directories
        public void ListarArquivosDiretorios(string caminho){
            var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
                                                            //call in a specific directory with txt extension and end with number 2
            foreach(var retorno in retornoArquivos){
                System.Console.WriteLine(retorno);
            }
        }

        //create directory 
        public void CriarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName); 

        }

        //delete directory
        public void ApagarDiretorio(string caminho, bool apagarArquivos){ 
            Directory.Delete(caminho, apagarArquivos); //receives a recursive paramether
        }

        //create text file
        public void CreateTextFile(string caminho, string conteudo){
            if(File.Exists(caminho)){
                
            }else{
                File.WriteAllText(caminho, conteudo);
            }
            
        }
        //create stream text file
        public void CreateTextFileStream(string caminho, List<string> conteudo){

            using (var stream = File.CreateText(caminho)){
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }

        }
        //add new stream text file
        public void AddText(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

        public void AddStreamText(string caminho, List<string> conteudo){

            using (var stream = File.AppendText(caminho)){
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }

        }

        //read a file
        public void LerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo){
                System.Console.WriteLine(linha);
            }
        }
        
        public void LerArquivoStream(string caminho){
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho)){
                while ((linha = stream.ReadLine()) != null){ //read the current line
                    System.Console.WriteLine(linha);
                }
            }
        }

        //move files
        public void MoverArquivo(string caminho, string novoCaminho){
            File.Move(caminho, novoCaminho);
        }

        //copy files
        public void CopiarArquivos(string caminho, string novoCaminho, bool overwrite){
            File.Copy(caminho, novoCaminho, overwrite); //copy receives a boolean; true if the destination file can be overwritten, otherwise, false
            // copies an existing file to a new file. overwriting a file of the same name is allowed
        }
        
        //delete files
        public void DeletarArquivos(string caminho){
            File.Delete(caminho);

        }
    }
}