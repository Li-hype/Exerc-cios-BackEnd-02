
int numero;


do { 
Console.WriteLine("Menu:");
Console.WriteLine("Opção 1: Exibir uma mensagem");
Console.WriteLine("Opção 2: Fazer uma soma");
Console.WriteLine("Opção 3: Sair");
Console.Write("Insira uma opção (De 1 a 3): ");


    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Insira um número válido.");
        Console.Write("Escolha uma opção: ");
    }


    switch (numero)
    {
        case 1:
            Console.WriteLine(" \nNão perca a esperança!");
            break;

        case 2:
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
            break;

        case 3:
            Console.WriteLine("Saindo do programa. Até mais!");
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine();
} while (numero != 3);

Console.WriteLine("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();

