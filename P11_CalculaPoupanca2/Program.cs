// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calcula poupança2");

//double valorInvestido = 1000;
Console.WriteLine("Digite valor da poupança:");
double valorIvestido = 1000;
//double valorInvestido = double.Parse(Console.ReadLine());

for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
{
    // Métodos de operação arítmetica
    //valorIvestido = valorIvestido + valorIvestido * 0.0036;
    //valorIvestido = valorIvestido * 1.0036;
    valorIvestido *= 1.0036;
    Console.WriteLine($"Após {contadorMes} meses, você terá R${valorIvestido}");
}
