using System;
class Program
{

    static int somaInteiros(int n)
    {
        int i, somaInt = 0;
        for(i = 0; i <= n; i++)
        {
            somaInt = somaInt + i;
        }
        return somaInt;
    }

    static int somaPares(int n)
    {
        return 2 * somaInteiros(n);
    }

    static int somaImpares(int n)
    {
        return (2 * (somaInteiros(n))) - n;
    }
    static void Main()
    {
        int n;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        Console.Write($"A Soma dos {n} primeiros números inteiros impares é: {somaImpares(n)}");
    }
}
