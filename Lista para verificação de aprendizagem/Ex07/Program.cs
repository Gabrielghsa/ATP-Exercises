/* Faça um algoritmo em C# que:
(a) leia o valor da temperatura ambiente em Celsius e a converta para Fahrenheit;
(b) leia o valor da temperatura ambiente em Fahrenheit e a converta para Celsius;
(c) escreva os resultados na tela.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double tempC, tempF;
        string escala;

        Console.Write("Em qual escala termométrica está a temperatura ambiente?: C/F ");
        escala = Console.ReadLine();

        if(escala == "C")
        {
            Console.Write("Qual a teperatura ambiente em Celsius?: ");
            tempC = double.Parse(Console.ReadLine());
            tempF = (tempC * 9/5) + 32;
            Console.Write($"A conversão de {tempC}°C para Fahrenheit é {tempF:f2}°");
        } else
        {
            Console.Write("Qual a teperatura ambiente em Fahrenheit?: ");
            tempF = double.Parse(Console.ReadLine());
            tempC = (tempF - 32) * 5/9;
            Console.Write($"A conversão de {tempF}°F para Celsius é {tempC:f2}°C");
        }


    }
}