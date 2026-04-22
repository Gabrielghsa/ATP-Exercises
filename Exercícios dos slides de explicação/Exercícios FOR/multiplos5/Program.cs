using System;
class Proram
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine($"Os multiplos de 5 menores que 500 são:");
        for (int cont = 0; cont <= 500; cont++)
        {
            if(cont % n == 0)
            {
            Console.WriteLine(cont);
                
            }
        }
    }
}
