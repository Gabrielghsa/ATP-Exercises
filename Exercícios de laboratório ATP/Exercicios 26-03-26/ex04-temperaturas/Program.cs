/*Faça um algoritmo em C# que leia uma opção de conversãao entre escalas de temperaturas conforme abaixo:
(a) Celsius para Fahrenheit
(b) Fahrenheit para Celsius*/

using System;
class Program
{
    static void Main()
    {
        char escala;
        float tempC, tempF;

        Console.WriteLine("Qual a escala da temperatura que você deseja converter?: C ou F ");
        escala = char.Parse(Console.ReadLine());

        switch (escala)
        {
            case 'C':
                Console.WriteLine("Qual a temperatura?: ");
                tempC = float.Parse(Console.ReadLine());
                tempF = (tempC * 9 / 5) + 32;
                Console.WriteLine($"A temperatura convertida para Fahrenheit é: {tempF:f2}");
                break;

            case 'F':
                Console.WriteLine("Qual a temperatura?: ");
                tempF = float.Parse(Console.ReadLine());
                tempC = (tempF - 32) * 5/9;
                Console.WriteLine($"A temperatura convertida para Celsius é: {tempC:f2}");
                break;
        }

    }
}

