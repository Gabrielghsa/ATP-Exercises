using System; 
class Program
{
    static double areaRetan(double baseR, double alturaR)
    {
        return baseR * alturaR;
    }
    static void Main()
    {
        Console.Write("Informe o valor da base: ");
        double baseR = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor da altura: ");
        double alturaR = double.Parse(Console.ReadLine());
        double area = areaRetan(baseR,alturaR);
        Console.Write($"O valor da área é: {area:f2}");
    }
}
