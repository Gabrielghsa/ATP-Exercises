using System;
class Program
{

    static double delta(double a, double b, double c)
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }

    static void Raizes(double a, double b, double c)
    {
        double resDelta = delta(a,b,c);
        double x1, x2;
        if(resDelta > 0)
        {
            x1 = (-b + Math.Sqrt(resDelta)) / (2*a);
            x2 = (-b - Math.Sqrt(resDelta)) /(2*a);
            Console.Write($"A equação possui duas raízes reais: x1 = {x1} e x2 = {x2}");
        }else if(resDelta == 0)
        {
            x1 = -b / (2*a);
            Console.Write($"A equação possui uma raíz real: x {x1}");
        }else
        {
            Console.Write("Delta = 0, portanto sem raízes reais");
        }
    }
    static void Main()
    {
        double a, b, c;
        Console.Write("Informe o valor de a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de c: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine($"Delta = {delta(a,b,c)}");
        Raizes(a,b,c);
    }
}
