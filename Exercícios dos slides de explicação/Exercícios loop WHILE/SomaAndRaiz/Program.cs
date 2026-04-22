using System;
    class SomaAndRaiz
{
    static void Main()
    {
        double num1, num2, soma, raiz;
                int op;
                Console.WriteLine("1-Somar dois números");
                Console.WriteLine("2-Raiz quadrada de um número");
                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Qual o primeiro valor?: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Qual o segundo valor?: ");
                    num2 = double.Parse(Console.ReadLine());
                    soma = num1 + num2;
                    Console.Write($"O valor da soma é: {soma}");
                } else if (op == 2)
                {
                    Console.Write("Digite um número para saber a raiz quadrada: ");
                    num1 = double.Parse(Console.ReadLine());
                    raiz = Math.Sqrt(num1);
                    Console.Write($"A raiz quadrada é: {raiz}"); 
                } else
                
                    Console.Write("Opção inválida");
    }
}