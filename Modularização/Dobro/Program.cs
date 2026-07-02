using System; 
class Program
{
    static int Dobro(int num)
    {
        return num * 2;
    }
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        int res = Dobro(num+2);
        Console.Write($"O dobro de {num} é: {res}");
    }
}
