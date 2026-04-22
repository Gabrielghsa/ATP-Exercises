using System;
class Program
{
    static void Main()
    {
        int fat = 1, cont; 
        Console.Write("Qual o número para calcular a sua fatorial?: ");
        cont = int.Parse(Console.ReadLine());
        for (int i = 1; i <= cont; i++)
        {
            fat = fat * i;
        }
        Console.Write($"A fatorial é: {fat}");
    }
}
