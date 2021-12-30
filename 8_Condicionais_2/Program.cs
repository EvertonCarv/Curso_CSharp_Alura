// See https://aka.ms/new-console-template for more information
Console.WriteLine("7_Condicionais_2");

//int idadeJoao = 16;
//int quantidadePessoas = 2;

Console.WriteLine("Informe Idade de João?");
int idadeJoao = int.Parse(Console.ReadLine());

Console.WriteLine("Informe número de pessoas?");
int quantidadePessoas = int.Parse(Console.ReadLine());

// bool só pode receber true or false
bool acompanhado = quantidadePessoas >= 2; 

 // if (idadeJoao >= 18 || quantidadePessoas >= 2) 
 // (|| Pepé) = Operador lógico (OR = OU = 0 + 0 = 0 = false ou 1 + 0 = 1 = true, veja tabela verdade) nesse caso se idade ou quantidade de pessoas for dentro do especificado dara positivo 
 // (&& E Comercial) Operador lógico e (AND = E = 1 * 1 = 1 = true ou 1 * 0 = 0 = false, veja tabela verdade) essa porta só dara true se todos os comparativos forem true 

if (idadeJoao >= 18 && quantidadePessoas >= 2)

    /* usando boll
if (idadeJoao >= 18 && acompanhado == true)*/
    {
    Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
}
else
{
    Console.WriteLine("Joao não possui mais de 18 anos, não pode entrar.");
}