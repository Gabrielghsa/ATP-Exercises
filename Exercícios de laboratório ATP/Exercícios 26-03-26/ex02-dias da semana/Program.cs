// Ler um número de 1 a 7 e retornar qual é o dia da semana correspondente 

using System;
class Program
{
    static void Main()
    {
        int dia;

        Console.WriteLine("Digite um número de 1-7");
        dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda-feira");
                break;

            case 3:
                Console.WriteLine("Terça-feira");
                break;

            case 4:
                Console.WriteLine("Quarta-feira");
                break;
                
            case 5:
                Console.WriteLine("Quita-feira");
                break;

            case 6:
                Console.WriteLine("Sexta-feira");
                break;
                
            case 7:
                Console.WriteLine("Sábado");
                break;

            default:
            Console.Write("Valor indisponível");
            break;
        }
    }
}
