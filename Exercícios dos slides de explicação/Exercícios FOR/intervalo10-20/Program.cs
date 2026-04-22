using System;
class Program
{
    static void Main()
    {
        int val, contD = 0, contF = 0;
        for(int cont = 1; cont <= 10; cont++)
        {
            Console.Write("Digite um valor: ");
            val = int.Parse(Console.ReadLine());
            if (val >= 10 && val <= 20)
            {
                contD += 1;
            }else
            {
                contF += 1;
            }

        }
        Console.WriteLine($"A quantidade de valores entre 10-20 é: {contD}");
        Console.WriteLine($"A quantidade de valores fora de 10-20 é: {contF}");
    }
}
