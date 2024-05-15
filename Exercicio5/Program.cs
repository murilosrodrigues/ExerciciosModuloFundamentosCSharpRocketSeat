using System.Text.RegularExpressions;

Console.WriteLine("Digite sua placa:");
string placa = Console.ReadLine();
if (placa.Replace("-", "").Length < 7)
    Console.WriteLine("Placa não é valida.");

var apenasLetras = Regex.Match(placa, @"^[A-Za-z]{3}").Success;
var saoNumeros = Regex.Match(placa, @"\d{4}$").Success;

if (apenasLetras && saoNumeros)
    Console.WriteLine($"A placa {placa} é valida.");
else
    Console.WriteLine($"A placa {placa} não é valida.");


