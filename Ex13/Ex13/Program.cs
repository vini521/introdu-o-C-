using static System.Runtime.InteropServices.JavaScript.JSType;

int numeroSecreto = 7;
int tentativa;

do
{
    Console.Write("Tente adivinhar o numero secreto: ");
    tentativa = int.Parse(Console.ReadLine());

    if ( tentativa != 7 )
    {
        Console.WriteLine("Você errou tente novamente");
    }
    else
    {
        Console.WriteLine("Parabens você adivinhou o numero secreto");
    }
} while(tentativa != 7);

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();
