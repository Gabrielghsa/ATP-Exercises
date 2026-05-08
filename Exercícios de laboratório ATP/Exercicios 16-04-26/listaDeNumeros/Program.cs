int n, soma = 0, menorVal = 0, qtdePares = 0, num;

Console.Write("Informe um número: ");
n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Digite o {i}° número");
    num = int.Parse(Console.ReadLine());

    soma = soma + num;
    if(i == 1)
    {
        menorVal = num;
    }
    if(num < menorVal)
    {
        menorVal = num;
    }

    if(num % 2 == 0)
    {
        qtdePares = qtdePares + 1;
    }

}
Console.WriteLine($"A soma dos números é: {soma}");
Console.WriteLine($"O menor valor é: {menorVal}");
Console.Write($"A quantidade de números pares é: {qtdePares}");
