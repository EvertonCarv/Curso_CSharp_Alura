// See https://aka.ms/new-console-template for more information
Console.WriteLine("Usando-for");

double valorInvestido = 1000;
double fatorRendimento = 1.0036;
double ano;

  
for(int contadorAno = 1; contadorAno <=5; contadorAno++)
{
    for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
    {             
        valorInvestido *= fatorRendimento;
    }
    fatorRendimento += 0.0010;
    //Console.WriteLine($"Ao término do investimento, você terá R$ {valorInvestido}");
}

Console.WriteLine($"Ao término do investimento, você terá R$ {valorInvestido}");