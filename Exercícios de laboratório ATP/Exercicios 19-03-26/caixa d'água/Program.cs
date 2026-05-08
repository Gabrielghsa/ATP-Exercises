/*
    Escolher 1 para caixa quadrangular ou 2 para cilíndrica
    Ler as dimensões da caixa e calcular (em metros) seu volume
    exibir as dimensões da caixa 
*/
using System;
class Program
{
    static void Main()
    {
        double compri = 0, larg = 0, altu = 0, volume = 0;
        int tipo;

        Console.WriteLine("Qual o tipo de caixa d'água?: Digite 1 para quadrangular ou 2 para cilíndrica");
        tipo = int.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:
            Console.WriteLine("Qual o comprimento da caixa d'água?: ");
            compri = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Qual a largura da caixa d'água?: ");
            larg = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Qual a altura da caixa d'água?: ");
            altu = double.Parse(Console.ReadLine()); 
            volume = compri * larg * altu;
            Console.WriteLine($"O comprimento é: {compri}m");
            Console.WriteLine($"A largura é: {larg}m");
            Console.WriteLine($"A altura é: {altu}m");
            Console.WriteLine($"O volume é: {volume:f2}m³");
            break;

            case 2:
            Console.WriteLine("Qual a altura da caixa d'água?: ");
            altu = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o raio da caixa d'água: ");
            double raio = double.Parse(Console.ReadLine()); 
            volume = Math.PI * Math.Pow(raio, 2) * altu;
            Console.WriteLine($"A altura é: {altu}m");
            Console.WriteLine($"O raio é: {raio}");
            Console.WriteLine($"O volume é: {volume:f2}m³");
            break;
        }
        Console.ReadKey();
    }
}
