using System;
class Program
{
    static void Main()
    {
        int idade = 0, cont = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Qual a idade da pessoa {i}°: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                cont += 1;
            }
        }
        Console.Write($"A quantidade de pessoas maiores de idade é: {cont}");
        Console.ReadKey();
    }
}