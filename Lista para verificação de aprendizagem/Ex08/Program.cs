/* Faça um algoritmo em C# que decida qual o menor e qual o maior valor de dois números informados pelo
usuário.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int maior, menor, num1, num2;

        Console.Write("Informe o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            maior = num1;
        } else
        {
            maior = num2;
        }
        if (num2 < num1)
        {
            menor = num2;
        }else
        {
            menor = num1;
        }
        Console.WriteLine($"O maior valor é: {maior}");
        Console.Write($"O menor valor é: {menor}");
    }
}