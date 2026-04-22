// Algoritmo de troco
using System;
class Program
{
    static void Main()
    {
        decimal pagam, troco, total;
        
        Console.WriteLine("Qual o valor da compra?: ");
        total = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Faça o pagamento");
        pagam = decimal.Parse(Console.ReadLine());

        troco = total - pagam;
        Console.WriteLine($"Seu troco é: {troco}");
    }
}
