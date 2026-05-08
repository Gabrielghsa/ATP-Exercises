int[] numPrimos;
int n, cont = 0;

Console.Write("Informe a quantidade e números: ");
n = int.Parse(Console.ReadLine());
numPrimos = new int[n];

for (int i = 0; i < numPrimos.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numPrimos[i] = int.Parse(Console.ReadLine());
}

for(int j = 0; j < numPrimos.Length; j++)
{
    if (primo(numPrimos[j]))
    {
        cont++;
    }
}
    Console.WriteLine($"Quantidade de números primos: {cont}");

    static int divisores(int n)
    {
        int i, cont = 0;
        for (i = 1; i <= n; i++)
            if (n % i == 0)
                cont++;
        return (cont);
    }

    static bool primo(int n)
    {
        if (n <= 1)
    {
        return divisores(n) == 2;
    }
        if (divisores(n) > 2)
            return (false);
        else
            return (true);
    }



