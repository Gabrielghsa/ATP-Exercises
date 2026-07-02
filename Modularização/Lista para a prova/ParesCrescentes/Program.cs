using System;
class Program
{
   static int par(int i)
    {
        return i * 2;
    }

    static void mostraPares(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(par(i));
        }
    }
    static void Main()
    {
        int n; 
        Console.Write("Informe o valor de n: ");
        n = int.Parse(Console.ReadLine());
        mostraPares(n);

    }
}
