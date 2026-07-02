using System; 
class Program
{

    static void decisao(int n, int op)
    {
        switch (op)
        {
            case 1: 
                Console.WriteLine($"{n} primeiros números positivos:");
                for(int i = 1; i <= n; i++)
                {
                    Console.Write(i + " - ");
                }
                break;
            case 2:

                Console.WriteLine($"{n} primeiros números positivo pares:");
                for(int i = 1; i <= n*2; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(i + " - ");
                    }
                }
                break;

            case 3: 
                Console.WriteLine($"{n} primeiros números positivo ímpares:");
                for(int i = 1; i <= n*2; i+=2)
                {
                    if(i % 2 != 0)
                    {
                        Console.Write(i + " - ");
                    }
                }
                break;

            case 4: 
                int soma = 0;
                for(int i = 1; i <= n; i++)
                {
                    soma = soma + i;
                }
                Console.Write($"A soma dos {n} primeiros números inteiros positivos é: {soma}");
                break;

            case 5:
                int somaPar = 0; 
                for(int i = 1; i <= n; i++)
                {
                    if(i % 2 == 0)
                    {
                        somaPar = somaPar + i;
                    }
                }
                Console.Write($"A soma dos {n} primeiros números inteiros positivos pares é: {somaPar}");
                break;

            case 6: 
                int somaImpar = 0;
                for(int i = 1; i <= n*2; i+=2)
                {
                    if(i % 2 != 0)
                    {
                        somaImpar = somaImpar + i;
                    }
                }
                Console.Write($"A soma dos {n} primeiros números inteiros positivos ímpares é: {somaImpar}");
                break;

                default:    
                    Console.Write($"Opção inválida...");
                    break;
        }
    }
    static void Main()
    {
        int n, op;
        Console.Write("Infomre um número: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Infomre uma opção entre 1-6: ");
        op = int.Parse(Console.ReadLine());
        decisao(n, op);
    }
}
