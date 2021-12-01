using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    class Calculadora // Esta classe esta implementando uma sobrecarga de métodos em tempo de compilação
    {
        public int Somar(int n1, int n2) 
        {
            return n1 + n1;
        }

        public int Somar(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
    }
}
