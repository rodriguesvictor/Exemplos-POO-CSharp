using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Interfaces
{
    interface ICalculadora 
    {
        int Somar(int n1, int n2); // Interfaces não precisam de modificadores de acesso
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        int Dividir(int n1, int n2) // método implementado na interface como padrão
        {
            return n1 / n2;
        }
    }
}
