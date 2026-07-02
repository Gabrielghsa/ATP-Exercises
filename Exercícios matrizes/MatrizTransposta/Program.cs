int m, n, linha, coluna;
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
        Console.Write($"Digite o número da posição {linha},{coluna}: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Matriz");
for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha,coluna] + "  ");
    }
    Console.WriteLine();
}


Console.WriteLine("Matriz transposta");
for(linha = 0; linha < matriz.GetLength(1); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(0); coluna++)
    {
        Console.Write(matriz[coluna,linha] + "  ");
    }
    Console.WriteLine();
}
