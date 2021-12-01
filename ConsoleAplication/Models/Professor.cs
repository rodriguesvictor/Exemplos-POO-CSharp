using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar() // Adicionando 'override' ao método significa que ele esta sendo sobrescrito com base na classe pessoa
        {
            Console.WriteLine($"Olá meu nome é {Nome}. Sou um professor e ganho {Salario}.");
        }
    }
}
