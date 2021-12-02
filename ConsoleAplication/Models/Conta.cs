using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    abstract class Conta
    {
        protected double saldo;


        public abstract void Creditar( double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }
        
        
        
    }
}
