using System; 
class Program
{

    static void somaInteiros(int n)
    {
        
        for(int i = 0; i <= n; i++)
        {
            Console.Write($"{i} - ");
        }
    }

    static void somaPares(int n)
    {
         
        for(int i = 0; i <= n*2; i++)
        {
            if(i % 2 == 0)
                Console.Write($"{i} - ");
        }
    }

    static void somaImpares(int n)
    {
         
        int cont = 0;
        for(int i = 0; cont < n; i++)
        {
            if(i % 2 != 0){
                Console.Write($"{i} - ");
                cont++;
            }
        }
    }
    static void Main()
    {
        int n;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        somaInteiros(n);
        Console.WriteLine();
        somaPares(n);
        Console.WriteLine();
        somaImpares(n);
    }
}
