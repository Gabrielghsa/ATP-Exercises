using System;

class Program
{
    static void Main()
    {
        double S = 0;

        for (int n = 1; n <= 50; n++)
        {
            S += (2.0 * n - 1) / n;
        }

        Console.WriteLine("Valor da série S = " + S);
    }
}