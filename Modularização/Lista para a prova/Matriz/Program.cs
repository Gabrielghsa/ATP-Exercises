using System;
class Program
{
    static void ExibeLinhaOuColuna(int[,] M, char tipo, int i)
    {
        int j;
        if(tipo == 'C')
        {
            for(j = 0; j < M.GetLength(0); j++)
            {
                Console.WriteLine($"{M[j, i]} - ");
            }
        }else if(tipo == 'L')
        {
            for(j = 0; j < M.GetLength(1); j++)
            {
                Console.Write($"{M[i, j]}");
            }
        }
    }
    static void Main()
    {
        int[,] M = {{ 1,  2,  3,  4,  5  },
                    { 6,  7,  8,  9,  10 },
                    {11, 12, 13, 14,  15 },
                    {16, 17, 18, 19,  20 }};
        int i;
        char tipo;

        Console.Write("Informe o tipo C para coluna ou L para linhas: ");
        tipo = char.Parse(Console.ReadLine());
        Console.Write("Informe a linha ou coluna da matriz a ser exibida: ");
        i = int.Parse(Console.ReadLine());
        ExibeLinhaOuColuna(M, tipo, i);
    }
}
