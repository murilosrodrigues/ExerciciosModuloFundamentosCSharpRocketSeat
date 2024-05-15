// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira a palavra ou frase para contarmos as letras:");
var informacao = Console.ReadLine().Trim();

Console.WriteLine($" você passou um total de : {informacao.Length} sem contar os espaços em branco");
