Console.WriteLine("Escolha um número entre 1 e 12, para saber a estação de acordo com o mês: ");
int numeroEscolhido = int.Parse(Console.ReadLine());

switch (numeroEscolhido)
{
    case 12:
        Console.WriteLine("A estação de Dezembro é: verão");
        break;

    case 1:
        Console.WriteLine("A estação de Janeiro é: verão");
        break;

    case 2:
        Console.WriteLine("A estação de Fevereiro é: verão");
        break;

    case 3:
        Console.WriteLine("A estação de Março é: outono");
        break;

    case 4:
        Console.WriteLine("A estação de Abril é: outono");
        break;

    case 5:
        Console.WriteLine("A estação de Maio é: outono");
        break;

    case 6:
        Console.WriteLine("A estação de Junho é: inverno");
        break;

    case 7:
        Console.WriteLine("A estação de Julho é: inverno");
        break;

    case 8:
        Console.WriteLine("A estação de Agosto é: inverno");
        break;

    case 9:
        Console.WriteLine("A estação de Setembro é: primavera");
        break;

    case 10:
        Console.WriteLine("A estação de Outubro é: primavera");
        break;

    case 11:
        Console.WriteLine("A estação de Novembro é: primavera");
        break;


    default:
        Console.WriteLine("O número escolhido não é válido");
        break;
};

Console.WriteLine("Digite uma tecla para encerrar o programa");
Console.ReadKey();

