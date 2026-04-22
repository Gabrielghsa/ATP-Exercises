using System; 
class Program
{
    static void Main(string[] args)
    {
        double num, raiz;

        Console.Write("Digite um número para tirar a raiz quadrada: ");
        num = double.Parse(Console.ReadLine());

        while (num > 0)
        {
            raiz = Math.Sqrt(num);
            Console.WriteLine($"A raiz quadrada de {num} é {raiz}");
            Console.Write("Digite um número para tirar a raiz quadrada: ");
            num = double.Parse(Console.ReadLine());
        }
        Console.Write("Valor inválido! Saíndo...");
    }
}
