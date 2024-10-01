Console.Write("Insira um numero para cmfirimos sua tabuada: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"A tabuada de {num} é: ");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num * i}");
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();