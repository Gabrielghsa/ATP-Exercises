int i, n, qtdPares = 0, qtdImpares = 0;
int[] valores;

Console.Write("Informe a qtd de números: ");
n = int.Parse(Console.ReadLine());
valores = new int[n];

for(i = 0; i < valores.Length; i++)
{
    Console.Write($"Informe o {i+1}° número: ");
    valores[i] = int.Parse(Console.ReadLine());
    if(valores[i] % 2 == 0)
    {
        qtdPares++;
    }else
    {
        qtdImpares++;
    }
}
Console.WriteLine($"A lista de números é: {string.Join(" - ", valores)}");
Console.WriteLine($"A qtd de números pares é: {qtdPares}");
Console.Write($"A qtd de números ímpares é: {qtdImpares}");

