int nota;

Console.Write("Insira sua nota: ");
nota = int.Parse(Console.ReadLine());

if (nota >= 90 & nota <= 100)
{
    Console.WriteLine("Você tirou nota A");
}
else if (nota >= 80 & nota <= 89)
{
    Console.WriteLine("Você tirou nota B");
}
else if (nota >= 70 & nota <= 79)
{
    Console.WriteLine("Você tirou nota C");
}
else if (nota >= 60 & nota <= 69)
{
    Console.WriteLine("Você tirou nota D");
}
else if (nota > 100)
{
    Console.WriteLine("Essa nota é invalida Porfavor digite uma nota menor que 100!!");
}
else
{
    Console.WriteLine("Você tirou F");
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();