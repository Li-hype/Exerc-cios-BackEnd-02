using System.Globalization;

try
{
    Console.Write("Digite um número: ");
    double num1;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num1))
    {
        Console.WriteLine("Erro: por favor digite um número válido");
        Console.Write("Digite o numerador: ");
    }

    Console.Write("Digite outro número: ");
    double num2;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
    {
        Console.WriteLine("Erro: por favor digite um número válido");
        Console.Write("Digite um número: ");
    }

    if (num2 == 0)
    {
        throw new DivideByZeroException();
    }


    double resultado = num1 + num2;
    Console.WriteLine($"O resultado da soma é: {resultado}");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possível somar com zero.");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos.");
}

Console.WriteLine("Aperte qualquer tecla para encerrar o programa");
Console.ReadKey();

