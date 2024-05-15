Console.WriteLine("Bem vindo ao Mensagens Personalizadas!");
Console.WriteLine("Digite seu nome:");
var nome  = Console.ReadLine();

while(nome.Trim().Length <= 0)
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
}

Console.WriteLine($"Olá,{nome}! Seja muito bem-vindo(a)!");