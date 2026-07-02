using System; 
class Program
{
    static void divisores(int num)
    {
        int i;
        for(i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                Console.WriteLine($"{i} é divisor de {num}");
            }
        }
    }
    static void Main()
    {
        int num;
        Console.Write("Informe um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        divisores(num);

    }
}
