/*Faça um algoritmo em C# que:
(a) leia três números reais (x, y e z);
(b) calcule a média aritmética M dos três valores;
(c) escreva os valores de x, y, z e M. */
using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y, z;
        double M;

        Console.Write("Qual o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Qual o valor de y: ");
        y = int.Parse(Console.ReadLine());
        Console.Write("Qual o valor de z: ");
        z = int.Parse(Console.ReadLine());

        M = (x + y + z) / 3;

        Console.Write($"Os válores {x}, {y} e {z} posuem média de valor: {M:f2}");

    }
}
