using System.Security.Cryptography;

Console.WriteLine("Escolha o formato que deseja ver a data atual:");
Console.WriteLine("1 - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
Console.WriteLine("2 - Apenas a data no formato '01 / 03 / 2024'.");
Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
Console.WriteLine("4 - A data com o mês por extenso.");
Console.WriteLine("5 - Todas as formas.");
var escolha = Convert.ToInt32(Console.ReadLine());
switch(escolha)
{
    case 1:
        Console.WriteLine(DateTime.Now.ToString("dddd, d , MM , yyyy , hh:mm:ss"));
        break;
    case 2:
        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        break;
    case 3:
        Console.WriteLine(DateTime.Now.ToString("HH"));
        break;
    case 4:
        Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        break;

    case 5:
        Console.WriteLine(DateTime.Now.ToString("dddd , d , MM , yyyy , hh:mm:ss"));
        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        Console.WriteLine(DateTime.Now.ToString("HH"));
        Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        break;

    default:
        Console.WriteLine("Opção invalida");
        break;
}