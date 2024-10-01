string[] vetDiaSemana = new string[]
{
    "Segunda-Feira",
    "Terça-Feira",
    "Quarta-Feira",
    "Quinta-Feira",
    "Sexta-Feira",
    "Sabado",
    "Domingo",
};

string[] tarefas = new string[7];

for (int i = 0; i < 7; i++)
{
    Console.Write($"insira tarefas para {vetDiaSemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}

Console.WriteLine("Precione qualquer tecla para finalizar");
Console.ReadKey();

