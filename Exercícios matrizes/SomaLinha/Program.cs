int m, n, linha, coluna, somaLinha;
double[] mediaLinha;
int[] resSomaLinha;
int[,] matriz;
Console.Write("Informe o número de linha da matriz: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe o número de colunas da matriz: ");
n = int.Parse(Console.ReadLine());
matriz = new int[m,n];


for(linha = 0; linha < m; linha++)
    
{
    for(coluna = 0; coluna < n; coluna++)
    {
        Console.Write($"Informe o número da posição {linha},{coluna}°: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
    }
}
resSomaLinha = new int[m];
mediaLinha = new double[m];

for(linha = 0; linha < m; linha++)
{
    somaLinha = 0;
    for(coluna = 0; coluna < n; coluna++)
    {
        somaLinha = somaLinha + matriz[linha,coluna];
        Console.Write(matriz[linha, coluna].ToString().PadLeft(4));
    }
    resSomaLinha[linha] = somaLinha;
    mediaLinha[linha] = (double)somaLinha / n;
    Console.WriteLine();
}
Console.WriteLine($"Soma das linhas: {string.Join("-", resSomaLinha)}");
Console.Write($"A média da linha é: {string.Join("-", mediaLinha)}");