using System; 
class Program
{
    static int Maior(int x, int y)
    {
        if(x > y)
        {
            return x;
        } else 
        {
            return y;
        }
    }
    static void Main()
    {
        int x = 344, y = 3493;
        Console.Write(Maior(x,y));
    }
}
