using System;

namespace Caracteres_Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Caractere e Texto");

             // character aspas simples usada para unico caracter ''
             char primeiraLetra = 'a';
             Console.WriteLine(primeiraLetra);

             primeiraLetra = (char) 61;
             Console.WriteLine(primeiraLetra);

             primeiraLetra = (char)(primeiraLetra + 1);
             Console.WriteLine(primeiraLetra);

             string tipo usado para representação de texto
             string titulo = "Alura Cursos de tecnologia " + 2020;
             string cursosProgramacao = @" - .NET 
                 - Java 
                 - Javascript";

             Console.WriteLine(titulo);

             Console.WriteLine(cursosProgramacao);
            */
           
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            // abaixo dois exemplos de concatenação
            string palavra = "Alura cursos online de tecnologia ";
            Console.WriteLine(palavra + 2020);

            /* esse modo podemos colocar o 2020 no final
            palavra = palavra + 2020;
            Console.WriteLine(palavra);
            */
        }
    }
}
