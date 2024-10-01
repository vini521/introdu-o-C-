using static System.Runtime.InteropServices.JavaScript.JSType;

int opção;

try
{
    do
    {
        Console.Write("\n1. Para Exibir uma mensagem \n2. Para fazer uma soma \n3. Para sair \nSelecione uma das opções: ");
        opção = int.Parse(Console.ReadLine());

        switch (opção)
        {
            case 1:
                Console.WriteLine("Luizinho lanches o Lanche do tamnho da sua foem");
                break;

            case 2:
                Console.Write("Digite um numero: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite outro numero para a soma: ");
                double num2 = double.Parse(Console.ReadLine());

                double soma = num1 + num2;

                Console.WriteLine($"A soma de {num1} com {num2} é: {soma}");
                break;

            case 3:
                Console.WriteLine("Você escolheu sair Tchau!!");
                break;
            default:
                Console.WriteLine("Opção invalida!!");
                break ;
        }

    } while (opção != 3);


}
catch (FormatException)
{
    Console.WriteLine("Opção invalida. digite apenas numeros!!");
}

Console.WriteLine("\n Precione qualquer tecla e finalize");
Console.ReadKey();