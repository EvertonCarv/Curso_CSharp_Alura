using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 Criando variaveis");

            int idade;  // int variavel do tipo inteiro 
            int idade2;
            int idade3 = 25;
            idade = 32;
            idade2 = 10;
            

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);
            //se usar Write ele fica na mesma lina / se usar WriteLine pula linha

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade);
            //Aspas igual texto se colocar um operador fora das aspas ele concatena com texto a esquerda
            //Preferencia de operadores na sequencia * / + - se colocar () tera preferencia 

            idade = 10 * idade2;
            Console.WriteLine("Nossa idade é " + idade);

            idade = 30 * idade2;
            Console.WriteLine("Idade = " + idade);

            idade3 = (10 / 2) * idade2;
            Console.WriteLine("Idade = " + idade3);

        }
    }
}
