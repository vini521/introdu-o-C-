try
{
    Console.Write("Escreva um numero para somalo a outro: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Escreva o segundo numero da soma: ");
    double num2 = double.Parse(Console.ReadLine());

    double soma = num1 + num2;
    Console.WriteLine($"A soma de {num1} com {num2} é {soma}");
}
catch (FormatException)
{
    Console.WriteLine("Erro: digite nueros validos!!");
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();