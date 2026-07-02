int m, n, linha, coluna;
int[,] matriz;
int[] maiorElem;

Console.Write("Informe o número de linhas: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe o número de colunas: ");
n = int.Parse(Console.ReadLine());

matriz = new int[m,n];
maiorElem = new int[m];

for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write($"Informe o número da posição {linha},{coluna}: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
        
    }
    
}

for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    maiorElem[linha] = matriz[linha,0];
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        if(matriz[linha,coluna] > maiorElem[linha])
        {
            maiorElem[linha] = matriz[linha,coluna];
        }
        Console.Write(matriz[linha,coluna] + "  ");
    }
    Console.WriteLine();
}
Console.Write($"Os maiores elementos de cada linha são: {string.Join(" ", maiorElem)}");

