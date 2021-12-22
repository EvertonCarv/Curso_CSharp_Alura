// See https://aka.ms/new-console-template for more information
Console.WriteLine("7_Condicionais_2");

//int idadeJoao = 16;
//int quantidadePessoas = 2;

Console.WriteLine("Informe Idade de João?");
int idadeJoao = int.Parse(Console.ReadLine());

Console.WriteLine("Informe número de pessoas?");
int quantidadePessoas = int.Parse(Console.ReadLine());

 // if (idadeJoao >= 18 || quantidadePessoas >= 2) // || Operador lógico ou (OR) nesse caso se idade ou quantidade de pessoas for dentro do especificado dara positivo 
if (idadeJoao >= 18 && quantidadePessoas >= 2) // && Operador lógico e (AND) nesse caso só dara certo se idade e quantidadepessoas bater com requisito mínimo
{
    Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
}
else
{
    Console.WriteLine("Joao não possui mais de 18 anos, não pode entrar.");
}