using System;
class Program
{
    static void Main()
    {
        int operacao, numElev, poten;
        double val1, val2, soma, sub, mult, divis, potenResul;

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Calculadora de 2 valores");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Digite 1 para soma:");
        Console.WriteLine("Digite 2 para subtrair:");
        Console.WriteLine("Digite 3 para multiplcar:");
        Console.WriteLine("Digite 4 para dividir:");
        Console.WriteLine("Digite 5 para potência:");
        Console.WriteLine("Qual operação você deseja realizar?:");
        operacao = int.Parse(Console.ReadLine());
        


        switch (operacao)
        {
            case 1:
                
                Console.WriteLine("Digite o primeiro número: ");
                val1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                val2 = double.Parse(Console.ReadLine());
                soma = val1 + val2;
                Console.WriteLine($"O resultado da soma é: {soma}");
                break;

            case 2:
               
                Console.WriteLine("Digite o primeiro número: ");
                val1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                val2 = double.Parse(Console.ReadLine());
                sub = val1 - val2;
                Console.WriteLine($"O resultado da subtração é: {sub}");
                break;

            case 3:
                
                Console.WriteLine("Digite o primeiro número: ");
                val1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                val2 = double.Parse(Console.ReadLine());
                mult = val1 * val2;
                Console.WriteLine($"O resultado da multiplicação é: {mult}");
                break;

            case 4:
                
                Console.WriteLine("Digite o primeiro número: ");
                val1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                val2 = double.Parse(Console.ReadLine());
                divis = val1 / val2;
                Console.WriteLine($"O resultado da divisão é: {divis}");
                break;

            case 5:
                Console.WriteLine("Qual o valor você quer elevar?:");
                numElev = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da potenciação?:");
                poten = int.Parse(Console.ReadLine());
                potenResul = Math.Pow(numElev, poten);
                Console.WriteLine($"O resultado da potenciação é: {potenResul}");

                break;

            default:
                Console.WriteLine("Operção inválida!!!");
                break;

        }





    }
}
