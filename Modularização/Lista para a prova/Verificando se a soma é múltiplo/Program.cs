using System;
class Program
{

    static void resultados(int soma, double media)
    {
         Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
    }

    static void Main()
    {
        int n1, n2, n3, soma;
        do
        {
            Console.Write("Informe o valor de n1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n3: ");
            n3 = int.Parse(Console.ReadLine());
            soma = n1+n2+n3;
        }while(soma % n1 == 0);
        double media = (double)soma / 3;
        resultados(soma, media);
    }
}
