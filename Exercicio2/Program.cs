Console.WriteLine("Bem vindo ao Mensagens Personalizadas!");
Console.WriteLine("Digite seu nome:");
var nome = Console.ReadLine();

while (nome.Trim().Length <= 0)
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
}

Console.WriteLine("Digite seu sobrenome:");
var sobrenome = Console.ReadLine();

while (sobrenome.Trim().Length <= 0)
{
    Console.WriteLine("Digite seu nome:");
    sobrenome = Console.ReadLine();
}

var nomeCompleto = nome +" "+ sobrenome;
Console.WriteLine($"Olá,{nomeCompleto}!!");
Console.WriteLine($"você tem um belo nome :)");