using System.Numerics;

try
{

    Console.Write("Digite um numero positivo e inteiro para verificarmos seu fatorial: ");
    int num = int.Parse(Console.ReadLine());
    if (num < 0)
    {
        Console.WriteLine("O programa não aceita numeros negativos");
    }
    else
    {

        int fat = 1;

        for (int i = 1; i <= num; i++)
        {
            fat *= i;
        }

        Console.WriteLine($"O fatorial de {num} é {fat}");
    }
}catch(FormatException)
{
    Console.WriteLine("Numero invalido digite um inteiro e positivo.");
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();