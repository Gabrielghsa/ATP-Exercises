

int m, n, linha, coluna, numAtual = 1, soma;
int[,] matriz;

Console.Write("Informe o número de linhas da matriz: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe o número de colunas da matriz: ");
n = int.Parse(Console.ReadLine());
matriz = new int[m,n];

//Preenchendo a matriz
for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        matriz[linha,coluna] = numAtual;
        numAtual++;
    }
}

//Exibindo a matriz e calculando o valor de cada linha
for(linha = 0; linha < matriz.GetLength(0); linha++)
{
    soma = 0;
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {

        Console.Write(matriz[linha,coluna].ToString().PadLeft(4));
        soma = soma + matriz[linha,coluna];

    }
    Console.Write($"  A soma da linha é {soma}");
    Console.WriteLine();
}
