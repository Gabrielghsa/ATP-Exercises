/*
    Não possui raízes se o delta for < 0
    delta = b²-4ac
    bhaskara = -b² +- delta /2a
*/

using System;
class Program
{
    static void Main()
    {
        double a, b, c, delta, x, x1, x2;
        Console.WriteLine("Qual é o coeficiente 'a'?: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o coeficiente 'b'?: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o coeficiente 'c'?: ");
        c = double.Parse(Console.ReadLine());
        
        delta = Math.Pow(b, 2) - 4*a*c;
        if (delta == 0)
        {
            x = -b + delta / 2*a;
            Console.WriteLine($"A equação possui uma raiz real: {x}");
        } else if (delta > 0)
        {
            x1 = (-b + delta) / 2*a;
            x2 = (-b - delta) / 2*a;
            Console.WriteLine($"A equação possui duas raízes reais: x1 = {x1} e x2 = {x2}");
        } else
        {
            Console.WriteLine("A equação não tem raizes, delta = 0");
        }
    }
}