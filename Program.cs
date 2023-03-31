
string Nome,Sobrenome;
Console.WriteLine();
Console.Write("digite seu nome....");
Nome = Console.ReadLine()!;
Console.WriteLine();
Console.Write("digite seu sobrenome ...");
Sobrenome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"nome completo: {Nome} {Sobrenome}");
Console.WriteLine($"nome de catalago {Sobrenome.ToUpper()}, {Nome}");
Console.WriteLine();

