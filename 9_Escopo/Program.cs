// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escopo");

int idadeJoao = 18;
bool acompanhado = true;
string mensagemAdicional;

if (acompanhado == true)
{
    mensagemAdicional = "João está acompanhado"; 
}
else
{
    mensagemAdicional = "João não está acompanhado";
}

if (idadeJoao >= 18 && acompanhado == true)
{
    Console.WriteLine("Pode entrar.");
    Console.WriteLine(mensagemAdicional);
}
else
{
    Console.WriteLine("Não pode entrar");
    Console.WriteLine(mensagemAdicional);
}