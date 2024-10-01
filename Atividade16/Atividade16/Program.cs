Console.Write("Digite um número positivo:");


if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
{
    long fatorial = 1;

    for (int i = 1; i <= num; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"A fatoração de {num} é: {fatorial}");
}
else
{
    Console.WriteLine("Por favor insira um númweo inteiro");
}

Console.ReadKey();

   
