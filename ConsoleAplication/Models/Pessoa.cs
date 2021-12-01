using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Documento { get; set; }

        public virtual void Apresentar() // Adicionando 'virtual' significa que o método pode ser sobrescrito
        {

            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
