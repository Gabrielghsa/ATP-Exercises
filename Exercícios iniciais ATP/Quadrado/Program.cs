/* Ler o comprimento de um arame, calcular qual o lado do quadrado que dá para formar com esse arame
    calcular a área desse quadrado e retornar o comprimento a área e o lado do quadrado
*/
using System;
class Program
{
    static void Main()
    {
        double arame, lado, area;
        Console.WriteLine("Qual o comprimento do arame em metros?: ");
        arame = double.Parse(Console.ReadLine());

        lado = arame / 4;
        area = Math.Pow(lado, 2);

        Console.WriteLine($"O comprimento do arame é: {arame}m");
        Console.WriteLine($"O lado do quadrado é: {lado}m");
        Console.WriteLine($"A área do quadrado é: {area:f2}m");
    }

}