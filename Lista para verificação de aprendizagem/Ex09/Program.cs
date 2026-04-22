/*Faça um algoritmo em C# que determine se um dado número inteiro (informado pelo usuário) é par ou ímpar*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.Write("Verifique de o número é par ou ímpar. Infomre um número: ");
        num = int.Parse(Console.ReadLine());

        if(num % 2 == 0)
        
            Console.Write($"O número: {num} é par"); //Quando só tiver um comando a ser executado dentro do if não ´recisa de chaves
            
         else
        
            Console.Write($"O número: {num} é ímpar");
            
        
    }
}