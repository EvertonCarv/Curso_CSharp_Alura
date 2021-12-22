using System;

namespace Conversao.Outros.Tipos.Numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão e outros tipos numericos!");
            
            double salario = 1200.50;

            // O int é um tipo de variavel que suporta valores de até 32 bits
            int salariointeiro = (int)salario; // casting converte double em inteiro neste caso
            int idade = 26;
            Console.WriteLine("Idade = " + idade);
            // int é uma variavel que suporta até 2^31 = 2147483648 variavel de 32bits na memoria

            // O long é variavel de 64bits de numeros inteiros
            long idade1 = 13000000000;
            Console.WriteLine("Idade do Universo Bilhoes = " + idade1);

            // O short é variavel de 16bits 
            short quantidadeprodutos = 18000;
            Console.WriteLine("Quantidade produtos = " + quantidadeprodutos);

            // Não traz suporte para casas decimais como o double caso queira usar precisa do sufixo (f)
            float altura = 1.80f;
            Console.WriteLine("Altura = " + altura);

            // Calculo usando 2 variaveis
            Console.WriteLine("Salario * quantidade de vendas = " + salariointeiro * quantidadeprodutos);

            Console.WriteLine("Salario = R$ " + salariointeiro);
            

            // Abaixo Exercicio
            /*
            float pontoflutuante = 3.14f;
            
            double salario1 = 1270.50;
            int valor = (int)salario1;
            Console.WriteLine("Meu Salario = " + valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine("Valor total = " + total);

            // Divisão usando tipo double
            Console.WriteLine("Salario / pontoflutuante = " + salario1 / pontoflutuante);

            // Divisão usando casting double para int
            Console.WriteLine("Salario / pontoflutuante usando casting = " + valor / pontoflutuante);
            */
        }
    }
}
