using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosPOO.Models
{
    class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}
