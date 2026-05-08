using System.Reflection.Metadata;

int n = 20, pares, impares;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        pares = i;
        Console.Write("Pares: ");
        Console.WriteLine(pares);
    }
}
for (int i = 1; i <= n; i++)
{

    if (i % 2 == 1)
    {
        impares = i;
        Console.Write("Ímpares: ");
        Console.WriteLine(impares);
    }

}

