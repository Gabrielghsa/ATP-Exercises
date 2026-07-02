using System; 
class Program
{
    static int fatorial(int x)
    {
        int i, fat = 1;
        for(i = x; i >= 1; i--)
        {
            fat = fat * i;
        }
        return fat;
    }

    static void Main()
    {
        int x; 
        Console.Write("Informe um número: ");
        x = int.Parse(Console.ReadLine());
        Console.Write($"A fatorial de {x} é: {fatorial(x)}");
    }
}
