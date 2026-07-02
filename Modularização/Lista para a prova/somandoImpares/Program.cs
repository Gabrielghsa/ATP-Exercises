using System;
class Program
{
    static int impar(int i)
    {
        return (i * 2) - 1;
    }

    static int somandoImpares(int n)
    {
       int somandoImpares = 0;
       for(int i = 1; i <= n; i++)
        {
            somandoImpares = somandoImpares + impar(i);
        }
        return somandoImpares;
    }

    static void Main()
    {
        int n; 
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        Console.Write($"A soma dos {n} primeiros números inteiros ímpares é: {somandoImpares(n)}");
    }
}
