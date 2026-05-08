using System; 
public class Program
{
    static void Main(string[] args)
    {
        int q1, q2;
        Console.Write("Informe o valor de q1: ");
        q1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de q2: ");
        q2 = int.Parse(Console.ReadLine());

        for(int i = 1; i <= q1; i++)
        {
            for(int j = 1; j <= q2; j++)
            {
                if(i == j)
                {
                    Console.WriteLine($"{i}, {j}");
                }
            }
        }
    
    }
}