using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExemplosPOO.Helper
{
    class FileHelper
    {
        public void ListarDiretorios(string caminho) 
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories); // o "*" faz trazer tudo que você colocar depois do *

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho) 
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories); // me traga qualquer coisa que tenha o final .txt

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }
    }
}
