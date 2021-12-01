using ExemplosPOO.Models;
using System;

namespace ExemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exemplo de Polimorfismo em tempo de compilação (Overload)
            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));


            // Exemplo de Polimorfismo em tempo de execução (Override)
            //Aluno p1 = new Aluno();
            //p1.Nome = "Victor";
            //p1.Idade = 20;
            //p1.Documento = "123456";
            //p1.Nota = 10;
            //p1.Apresentar();

            //Professor p2 = new Professor();
            //p2.Nome = "Rodrigues";
            //p2.Idade = 20;
            //p2.Documento = "123456";
            //p2.Salario = 100;
            //p2.Apresentar();

            // Exemplo de Herança
            //Professor p1 = new Professor();
            //p1.Salario = 200;
            //p1.Nome = "Victor";
            //p1.Idade = 20;
            //p1.Documento = "123456";
            //p1.Apresentar();


            // Exemplo de Encapsulamento
            // valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            // Console.WriteLine($"Área: {r.ObterArea()}");

            // valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // Console.WriteLine($"Área: {r2.ObterArea()}");

            // Exemplo de Abstração
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Victor";
            // p1.Idade = 20;

            // p1.Apresentar();

        }
    }
}
