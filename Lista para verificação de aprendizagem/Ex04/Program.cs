/*Faça um algoritmo em C# que:
(a) leia dois valores numéricos inteiros;
(b) calcule o resultado das quatro operações aritméticas (adição, subtração, multiplicação e divisão);
(c) exiba os valores dos números e dos resultados na tela.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, soma, subt, mult, divs; 
        
        Console.Write("Digite um número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        num2 = int.Parse(Console.ReadLine());

        soma = num1 + num2;
        subt = num1 - num2;
        mult = num1 * num2;
        divs = num1 / num2;

        Console.WriteLine($"O resultado de {num1} + {num2} é: {soma}");
        Console.WriteLine($"O resultado de {num1} - {num2} é: {subt}");
        Console.WriteLine($"O resultado de {num1} * {num2} é: {mult}");
        Console.WriteLine($"O resultado de {num1} / {num2} é: {divs}");
    }
}