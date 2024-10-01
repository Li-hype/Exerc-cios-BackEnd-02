Console.Write("Digite um número positivo: ");
double numero = double.Parse(Console.ReadLine());

Console.WriteLine($"A tabuada de {numero} é:");
for (int i = 1; i <= 10; i++ )
{
    Console.WriteLine(numero * i);
}

Console.ReadKey();