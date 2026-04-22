/*Faça um algoritmo em C# que decida, a partir de dois números informados pelo usuário, qual é o menor e qual
é o maior ou se são iguais.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2; 

        Console.Write("Informe o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o primeiro número: ");
        num2 = int.Parse(Console.ReadLine());

        if(num1 > num2)
        {
            Console.WriteLine($"O número {num1} é o maior");
            Console.Write($"O número {num2} é o menor");

        } else if(num2 > num1)
        {
            Console.WriteLine($"O número {num2} é o maior");
            Console.Write($"O número {num1} é o menor");

        } else
        {
            Console.Write("Os números são iguais");
        }
    }
}