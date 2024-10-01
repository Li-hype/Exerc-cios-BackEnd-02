int num;
Console.Write("Digite um número positivo:");


while (int.TryParse(Console.ReadLine(), out num) && num <= 0)
{
    Console.WriteLine("Por favor, insira um número inteiro positivo: ");
    Console.Write("Digite um número inteiro positivo: ");
}

Console.WriteLine($"Números ímpares até {num} são: ");

for (int i = 1; i <= num; i += 2) 
{
    Console.WriteLine(i);
}

Console.WriteLine("Pressione qualquer tecla para encerrar o programa");
Console.ReadKey();