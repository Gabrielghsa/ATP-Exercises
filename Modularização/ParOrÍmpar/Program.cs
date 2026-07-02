using System; 
class Program
{
    static bool parImpar(int num)
    {
        return num % 2 == 0;
    }
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        if (!parImpar(num))
        {
            Console.Write("O número é ímpar!");
        } else
        {
            Console.Write("O número é par!");
        }
    }
}
