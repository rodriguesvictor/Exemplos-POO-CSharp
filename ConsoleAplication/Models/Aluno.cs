using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    //Aplicando o conceito de Herança, Aluno Herda de Pessoa
    class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() // Adicionando 'override' ao método significa que ele esta sendo sobrescrito com base na classe pessoa
        {
            Console.WriteLine($"Olá meu nome é {Nome}. Sou um aluno de nota {Nota}.");
        }
    }
}
