using System;
class Public
{

    static void Saudacao(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    static int Soma(int x, int y)
    {
        return x + y;
    }

    static double Media(double a, double b)
    {
        return (double)(a + b) / 2;
    }

    static void VerificaAprov(double media)
    {
        if(media >= 7)
        {
            Console.Write("Aprovado");
        }else if(media >= 5 && media < 7)
        {
            Console.Write("Recuperação");
        } else
        {
            Console.Write("Reprovado");
        }
    }

    static string EhPar(int n)
    {
        if(n % 2 == 0)
        {
            return "Par";
        }else
        {
            return "Ímpar";
        }
    }

    static void Tabuada(int tabu)
    {
        int i, resul;
        for(i = 0; i <= 10; i++)
        {
            resul = i * tabu;
            Console.WriteLine($"{tabu} x {i} = {resul}");
        }
    }

    static double Potencia(int num, int pot)
    {
        return Math.Pow(num, pot); 
    }


    static void Main()
    {
        string nome;
        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine();
        Saudacao(nome);

        /* int x, y;
        Console.Write("Valor de X: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Valor de Y: ");
        y = int.Parse(Console.ReadLine());
        Console.Write($"A soma é: {Soma(x,y)}"); */

       /*  double a, b;
        Console.Write("Valor de A: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Valor de B: ");
        b = double.Parse(Console.ReadLine());
        double media = Media(a,b);
        Console.WriteLine($"A média é: {Media(a,b):f2}");
        VerificaAprov(media); */ 

    /*     int n;
        Console.Write("Infomre um número: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"O nómero {n} é: {EhPar(n)}"); */

       /*  int tabu; 
        Console.Write("Informe um número: ");
        tabu = int.Parse(Console.ReadLine());
        Tabuada(tabu); */

        /* int num, pot;
        Console.Write("Informe o valor da base: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor da potência: ");
        pot = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num} elevado a {pot} é: {Potencia(num, pot)}"); */
        

    }
}