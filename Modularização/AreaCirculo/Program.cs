using System; 
class Program
{
    static double areaCirc( double r)
    {
        double pI = Math.PI;
        double area = pI * Math.Pow(r,2);
        return area;
    }
    static void Main()
    {
        double r;
        Console.Write("Qual o valor do raio: ");
        r = double.Parse(Console.ReadLine());
        Console.Write($"A área do circulo é: {areaCirc(r):f2}");
    }
}
