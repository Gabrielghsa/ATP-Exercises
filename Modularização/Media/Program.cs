using System; 
class Program
{
    static double Media(double x, double y)
    {
        return (x + y)/2; 
    }

    static void MediaX()
    {
        if(Media(10, 6) > 8)
        {
            Console.Write("Aprovado");
        }else
        {
            Console.Write("Reprovado");
        }
    }
    static void Main()
    {
        MediaX();
        
    }
}

        /* Console.Write("Informe a primeira nota: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Informe a segunda nota: ");
        double y = double.Parse(Console.ReadLine());
        double res = Media(x,y);
        Console.Write($"A média é: {res}"); */