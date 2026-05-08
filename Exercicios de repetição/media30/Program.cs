//Calcular a média de 3 valores até que ela seja maior ou igual a 30;
int x, y, z, soma;
double media;

do
{
    x = 0;
    y = 0;
    z = 0;
    soma = 0;
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Informe o valor de x: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor de y: ");
    y = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor de z: ");
    z = int.Parse(Console.ReadLine());
    soma = x + y + z;
    media = soma / 3;
    Console.WriteLine($"A média é: {media}");
} while (media < 30);