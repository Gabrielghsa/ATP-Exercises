int m, n, linha, coluna, somaLinha = 0, somaColuna = 0, i, j; 
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
        Console.Write($"Informe o valor da posição {linha},{coluna}°: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Informe uma linha: ");
i = int.Parse(Console.ReadLine());
Console.Write("Informe uma coluna: ");
j = int.Parse(Console.ReadLine());

//Somando linha

    somaLinha = 0;
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        somaLinha = somaLinha + matriz[i,coluna];
    }

//Somando coluna

    somaColuna = 0;
    for(linha = 0; linha < matriz.GetLength(0); linha++)
    {
        somaColuna = somaColuna + matriz[linha, j];
    }


for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha,coluna] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine($"A soma da linha {i} é: {somaLinha}");
Console.WriteLine($"A soma da coluna {j} é: {somaColuna}");