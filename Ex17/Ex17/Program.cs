using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Informe um numero positivo");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Numeros impares de 0 até {num}");
for (int i = 1; i < num; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();