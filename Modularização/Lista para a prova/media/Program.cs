using System; 
class Program
{
    static double media(int num1, int num2, int num3)
    {
        return (num1 + num2 + num3) / 3;
    }
    static void Main()
    {
        int num1, num2, num3;
        Console.Write("Informe um número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe um número: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Informe um número: ");
        num3 = int.Parse(Console.ReadLine());
        double mediaArit = media(num1, num2, num3);
        Console.Write($"A média é: {mediaArit}");
    }
}
