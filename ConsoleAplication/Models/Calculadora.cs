using System;
using System.Collections.Generic;
using System.Text;
using ExemplosPOO.Interfaces;

namespace ExemplosPOO.Models
{
    // Esta classe esta implementando uma sobrecarga de métodos em tempo de compilação
    class Calculadora : ICalculadora // Implementação da Interface com seus métodos
    {
      
   
        public int Somar(int n1, int n2) 
        {
            return n1 + n1;
        }

        public int Somar(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
