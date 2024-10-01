string[] semana = new string[] {
  "Segunda-Feira",
  "Terça-Feira",
  "Quarta-Feira",
  "Quinta-Feira",
  "Sexta-Feira",
  "Sábado",
  "Domingo"
};


string[] tarefa = new string[7];

for (int i = 0; i < 7; i++)
{
    Console.Write($"Tarefas para {semana[i]}: ");
    tarefa[i] = Console.ReadLine();
}


Console.Write("Aperte uma tecla para encerrar o programa.");
Console.ReadKey();

