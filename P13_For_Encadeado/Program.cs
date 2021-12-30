// See https://aka.ms/new-console-template for more information
Console.WriteLine("For Encadeado");

for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {
        Console.Write("*");
       if (contadorColuna >= contadorLinha)
          break;
    }
    Console.WriteLine();// pula linha
}

// forma diferente de fazer desenho *
/*for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        Console.WriteLine("*");
    }
    Console.WriteLine();// pula linha
}*/