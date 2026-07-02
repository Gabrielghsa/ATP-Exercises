int q, i, maiorValor;
int[] valores;

Console.Write("Informe a quantidade de valores: ");
q = int.Parse(Console.ReadLine());
valores = new int[q];
for(i = 0; i < valores.Length; i++)
{
    Console.Write($"Informe o {i+1}° número: ");
    valores[i] = int.Parse(Console.ReadLine());
}
maiorValor = valores[0];

for(i = 0; i < valores.Length; i++)
{
    if(valores[i] > maiorValor)
    {
        maiorValor = valores[i];
    }
}
Console.WriteLine($"Maior valor: {maiorValor}");
Console.Write("Posições: ");
for(i = 0; i < valores.Length; i++)
{
    if(valores[i] == maiorValor)
    {
        Console.Write($"{i} ");
    }
}
