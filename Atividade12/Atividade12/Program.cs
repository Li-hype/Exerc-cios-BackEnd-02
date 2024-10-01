double nota;
Console.Write("Informe sua nota: ");
double.TryParse(Console.ReadLine(), out nota);


if (nota>= 90 && nota<=100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você tirou A");
    Console.ResetColor();
}
else if (nota>= 80 && nota<=89)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Você tirou B");
    Console.ResetColor();
}
else if (nota >= 70 && nota <= 79)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você tirou C");
    Console.ResetColor();
}
else if (nota >= 60 && nota <= 69)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Você tirou D");
    Console.ResetColor();
}
else if (nota<= 60)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você tirou F");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Erro: Digite sua nota novamente.");
}


Console.WriteLine("Programa encerrado");
Console.ReadKey();
