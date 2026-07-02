using System;
class Program
{
    static int soma(int x, int y)
    {
        return x + y;
    }

    static int subtrair(int x, int y)
    {
        return x - y;
    }

    static double divisao(double a, double b)
    {
        return a / b;
    }

    static int multiplicar(int x, int y)
    {
        return x * y;
    }
    static void Main()
    {
        int n;


            Console.Write("Informe o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de y: ");
            int y = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para dividir");
            Console.WriteLine("Digite 4 para multiplicar");
            Console.WriteLine("Digite 0 para sair");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                int res = soma(x, y);
                Console.WriteLine($"O resulado da soma é: {res}");
            }
            else if (n == 2)
            {
                int res = subtrair(x, y);
                Console.WriteLine($"O resultado da subtração é: {res}");
            }
            else if (n == 3)
            {
                Console.Write("Informe o valor de a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de b: ");
                double b = double.Parse(Console.ReadLine());
                double res = divisao(a, b);
                Console.WriteLine($"O resultado da divição é: {res}");
            }
            else if (n == 4)
            {
                int res = multiplicar(x, y);
                Console.WriteLine($"O resultado da multiplicação é: {res}");
            }

        } while (n != 0);
        Console.ReadKey();
    }

}