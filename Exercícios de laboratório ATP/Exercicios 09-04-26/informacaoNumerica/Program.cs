int num, n, soma = 0, maior = 0, menor = 0, pares = 0, impares = 0, positivos = 0, negativos = 0, nulos = 0;
double media;

Console.Write("Informe a quantidade de números: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"Informe o {i}° número: ");
    num = int.Parse(Console.ReadLine());

    soma = soma + num;

    if(i == 1)
    {
        maior = num;
        menor = num;
    } else
    {
        if(num > maior)
            maior = num;
    }   if(num < menor)
            menor = num;

    if (num % 2 == 0)
    {
        pares = pares + 1;
    }else
    {
        impares = impares + 1;
    }

    if (num > 0)
    {
        positivos = positivos + 1;
    } else if (num < 0)
    {
        negativos = negativos + 1;
    } else
    {
        nulos = nulos + 1;
    }
}
media = (double)soma / n;
Console.WriteLine($"A soma dos valores é: {soma}");
Console.WriteLine($"A média desses valoes é: {media}");
Console.WriteLine($"O maior valor é: {maior}");
Console.WriteLine($"O menor valor é: {menor}");
Console.WriteLine($"A quantidade de números pares é: {pares}");
Console.WriteLine($"A quantidade de números ímpares é: {impares}");
Console.WriteLine($"A quantidade de números positivos é: {positivos}");
Console.WriteLine($"A quantidade de números negativos é: {negativos}");
Console.WriteLine($"A quantidade de números nulos é: {nulos}");
