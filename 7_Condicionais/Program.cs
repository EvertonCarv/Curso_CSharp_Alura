// See https://aka.ms/new-console-template for more information
Console.WriteLine("7_Condicionais");

//int idadeJoao = 16;
//int quantidadePessoas = 2;

Console.WriteLine("Informe Idade de João?");
int idadeJoao = int.Parse(Console.ReadLine());

Console.WriteLine("Informe número de pessoas?");
int quantidadePessoas = int.Parse(Console.ReadLine());

if (idadeJoao >= 18)
{
    Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
}
else
{
    if (quantidadePessoas >= 2)
    {
        Console.WriteLine("Joao não possui mais de 18 anos, mas está acompanhado.");
    }
    else
    {
        Console.WriteLine("Joao não possui mais de 18 anos, não pode entrar.");
    }
}