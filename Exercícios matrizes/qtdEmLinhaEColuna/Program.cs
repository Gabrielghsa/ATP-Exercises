int m, n, linha, coluna, x, contLinha, contColuna;
int[,] matriz;
Console.Write("Informe o número de linhas: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe o número de colunas: ");
n = int.Parse(Console.ReadLine());
matriz = new int[m,n];

for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write($"Informe o valor da posição {linha},{coluna}: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Informe um número: ");
x = int.Parse(Console.ReadLine());
for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    contLinha = 0;
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        if(matriz[linha,coluna] == x)
        {
            contLinha++;
        }
    }
    Console.WriteLine($"linha {linha}: {contLinha}");
}
for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
{
    contColuna = 0;
    for(linha = 0; linha < matriz.GetLength(0); linha++)
    {
        if(matriz[linha,coluna] == x)
        {
            contColuna++;
        }
    }
    Console.WriteLine($"Coluna {coluna}: {contColuna}");
}

for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha,coluna] + "  ");
    }
    Console.WriteLine();
}



