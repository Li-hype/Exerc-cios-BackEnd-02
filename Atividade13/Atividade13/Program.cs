using System;

int numero;
do
{
    Console.Write("Digite um número inteiro para descobrir o número secreto (1 a 20): ");
    numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou: {numero}");
} while (numero != 7);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Parábens, você acertou o número secreto!!!");
Console.ReadKey();



