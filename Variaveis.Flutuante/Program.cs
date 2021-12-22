using System;

namespace Variaveis.Flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variavel tipo Double ponto flutuante");

            double salario = 1200.70; // double aceita virgula e numeros quebrados
            double idade = 15.0 / 2; // int somente numeros inteiros 

            Console.WriteLine("Salario " + salario);

            Console.WriteLine("Minha idade " + idade);

            idade = 5 / 3;
            Console.WriteLine("Idade 5 / 3 =  " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("Idade 5.0 / 3 =  " + idade);

            Console.WriteLine("Divisao de salario = " + salario / idade);
        }
    }
}
