// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calcula poupança");

//double valorInvestido = 1000;
Console.WriteLine("Digite valor da poupança:");

double valorInvestido = double.Parse(Console.ReadLine());
int contadorMes = 1;

while (contadorMes <= 12) // while =  enquanto / se retorna true vai sendo executado quando false para.
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine($"Após {contadorMes} meses, você terá R$ {valorInvestido}"); // concatenando usando interpolação de string

    // usando contadores tipos possiveis
    // contadorMes = contadorMes + 1;
    // contadorMes += 1;
    contadorMes++;
}

// 0.36% é igual a 0.0036 resumindo primeiro 0 antes do . é = 100% depois do ponto descreve valor da % desejada tipo 15% = 0.1500 / 9% = 0.0900 / 0.5% = 0.0050
