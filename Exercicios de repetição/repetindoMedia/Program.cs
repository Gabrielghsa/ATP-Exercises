int n, x, y, z, soma = 0;
double media;

Console.WriteLine("Digite a quantidade de vezes que a media de 3 números será calculada(Valor máximo de repetiçôes = 5): ");
n = int.Parse(Console.ReadLine());

if (n <= 5)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("Informe o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de y: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de z: ");
        z = int.Parse(Console.ReadLine());
        soma = x + y + z;
        media = soma / 3;
        Console.WriteLine($"A média entre {x}, {y} e {z} é: {media:f2}");
    }
}else
{
    Console.Write("ERRO. Número máximo de repetições excedido!");
}
