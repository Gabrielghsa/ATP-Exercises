using System;
class Program
{
    static void Main()
    {
        int n, soma = 0;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        for (int cont = 1; cont <= n; cont++)
        {
            soma = soma + cont;
        }
            Console.WriteLine($"A soma é: {soma}");
    }
}