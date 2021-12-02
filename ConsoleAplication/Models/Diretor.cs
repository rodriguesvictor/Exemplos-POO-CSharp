using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    class Diretor : Professor
    {
        public override void Apresentar() // Adicionando 'override' ao método significa que ele esta sendo sobrescrito com base na classe pessoa
        {
            Console.WriteLine("Diretor.");
        }
    }
}
