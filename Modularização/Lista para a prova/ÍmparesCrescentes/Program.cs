using System;
class Program
{
    static int impar(int i)
    {
        return (i * 2) - 1;
    }

    static void mostraImpares(int n)
    {
        for(int i = 1; i <=n; i++)
        {
            Console.WriteLine(impar(i));
        }
    }

    
    static void Main()
    {
        int n;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        mostraImpares(n);
    }
}
