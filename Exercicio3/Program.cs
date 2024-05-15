Double numero1 = 0,numero2 = 0;


Console.WriteLine("Olá, você deseja testar:");
Console.WriteLine("1 - Inserindo números.");
Console.WriteLine("2 - Usando aleatórios");
var respostaMenu1 = Convert.ToInt32(Console.ReadLine());

switch (respostaMenu1)
{
    case 1:
        Console.WriteLine("Insira o primeiro número:");        
        numero1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Insira o segundo número:");
        numero2 = Convert.ToDouble(Console.ReadLine());
        break;

    case 2:
        var random = new Random();
        numero1 = random.NextDouble();
        numero2 = random.NextDouble();
        break;

    default:
        Console.WriteLine("Opção escolhida não é valida.");
        break;

}


Console.WriteLine("Qual operação você deseja?");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Média");
Console.WriteLine("6 - Todas as operações!");
int respostaMenu2 = Convert.ToInt32(Console.ReadLine());
switch(respostaMenu2)
{
    case 1:
        Console.WriteLine($"A soma entre os numeros {numero1} e {numero2} é  igual a {numero1 + numero2}");
        break;

    case 2:
        Console.WriteLine($"A subtração entre os numeros {numero1} e {numero2} é  igual a {numero1 - numero2}");
        break;

    case 3:
        Console.WriteLine($"A multiplicação entre os numeros {numero1} e {numero2} é  igual a {numero1 * numero2}");
        break;

    case 4:

        if(numero2 == 0)
            Console.WriteLine("Não é possível dividir por zero");
        else
            Console.WriteLine($"A divisão entre os numeros {numero1} e {numero2} é  igual a {numero1 + numero2}");
        break;

    case 5:
        Console.WriteLine($"A media entre os numeros {numero1} e {numero2} é  igual a {(numero1 + numero2) / 2}");
        break;

    case 6:
        Console.WriteLine($"A soma entre os numeros {numero1} e {numero2} é  igual a {numero1 + numero2}");
        Console.WriteLine($"A subtração entre os numeros {numero1} e {numero2} é  igual a {numero1 - numero2}");
        Console.WriteLine($"A multiplicação entre os numeros {numero1} e {numero2} é  igual a {numero1 * numero2}");
        if (numero2 == 0)
            Console.WriteLine("Não é possível dividir por zero");
        else
            Console.WriteLine($"A divisão entre os numeros {numero1} e {numero2} é  igual a {numero1 + numero2}");
        Console.WriteLine($"A media entre os numeros {numero1} e {numero2} é  igual a {(numero1 + numero2) / 2}");

        break;

    default:
        Console.WriteLine("A opção escolhida não é valida");
        break;
}