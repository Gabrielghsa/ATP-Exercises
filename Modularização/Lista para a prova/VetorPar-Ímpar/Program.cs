using System; 
class Program
{

    static int[] geraVetor(int n)
    {
        int[] V;
        int i;
        V = new int[n];
        Console.WriteLine($"Informe os {n} elementos do vetor: ");
        for(i = 0; i < V.Length; i++)
        {
            Console.Write($"{i+1}°. Elemento: ");
            V[i] = int.Parse(Console.ReadLine());
        }
        return V;
    }

    static int contaPares(int[] V)
    {
        int i, cont = 0;
          for(i = 0; i < V.Length; i++)
        {
            if(V[i] % 2 == 0)
            {
                cont++;
            }
        }
        return cont;
    }
    static int contaImpares(int[] V)
    {
        int i, cont = 0;
         for(i = 0; i < V.Length; i++)
        {
            if(V[i] % 2 != 0)
            {
                cont++;
            }
        }
        return cont;
    }
    static void Main()
    {
        int[] V;
        int n, i;
        Console.Write("Informe o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        V = geraVetor(n);
        Console.WriteLine($"Números pares no vetor: {contaPares(V)}");
        Console.WriteLine($"Números pares no vetor: {contaImpares(V)}");

        

      


       

    }
}
