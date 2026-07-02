using System; 
class Program
{
    static bool numPrimo(int num)
    {
        int i, qtd = 0;
        for(i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                qtd++;
            }
        }
        if (qtd == 2)
        {
            return true;
        } else
        {
            return false;
        }
    }
    static void Main()
    {
        int num;
        Console.Write("Informe um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        Console.Write(numPrimo(num));
    }
}
