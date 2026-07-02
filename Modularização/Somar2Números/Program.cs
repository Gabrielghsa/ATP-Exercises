using System;
class Program
{
    static int soma(int x, int y)
    {
        return x + y;
    }
    static void Main()
    {
        Console.Write("Informe o valor de x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de y: ");
        int y = int.Parse(Console.ReadLine());
        int resultado = soma(x,y);
        Console.Write($"A soma é: {resultado}");
    }
}
