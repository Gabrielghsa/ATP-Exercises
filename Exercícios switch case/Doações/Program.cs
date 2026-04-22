using System;
class Program
{
    static void Main()
    {
        int escolha;
        double outroValor;
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Sistema de Doações");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Qual o valor você deseja doar?");
        Console.WriteLine("Digite 1 para doar 10 reais:");
        Console.WriteLine("Digite 2 para doar 15 reais:");
        Console.WriteLine("Digite 3 para doar 20 reais:");
        Console.WriteLine("Digite 4 para doar 50 reais:");
        Console.WriteLine("Digite 5 para doar outro valor: ");
        Console.Write("Digite a sua opção de doação: ");
        escolha = int.Parse(Console.ReadLine());

        switch (escolha) {
            case 1: 
                Console.WriteLine("Você doou R$10 reais");
                break;

            case 2: 
                Console.WriteLine("Você doou R$15 reais");
                break;

            case 3: 
                Console.WriteLine("Você doou R$20 reais");
                break;

            case 4: 
                Console.WriteLine("Você doou R$50 reais");
                break;

            case 5: 
                Console.WriteLine("Qual o valor você quer doar?: ");
                outroValor = double.Parse(Console.ReadLine());
                Console.Write($"Doação de: R${outroValor} concluída");
                
                break;

            default: 
                Console.WriteLine("Opção inválida. Tente novamente!!!");
                break;

        }
        Console.ReadKey();
    }
}

