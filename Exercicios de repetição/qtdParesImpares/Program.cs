int n, qtdePares = 0, qtdeImpares = 0;

Console.Write("Informe a quantidade de números que serão analisados: ");
n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        qtdePares++;
    }else
    {
        qtdeImpares++;
    }
}
Console.WriteLine($"A quantidade de números pares é: {qtdePares}");
Console.WriteLine($"A quantidade de números ímpares é: {qtdeImpares}");