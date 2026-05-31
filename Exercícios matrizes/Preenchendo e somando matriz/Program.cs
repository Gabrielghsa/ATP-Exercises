int m, n, linha, coluna, valor = 1, somaLinha;
int[,] matriz;
Console.Write("Informe o número de linhas da matriz: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe o número de colunas da matriz: ");
n = int.Parse(Console.ReadLine());
matriz = new int [m,n];

for(linha = 0; linha < m; linha++)
{
    for(coluna = 0; coluna < n; coluna++)
    {
        matriz[linha,coluna] = valor;
        valor++;
        
        
    }
    
}
Console.WriteLine("Matriz preenchida");
for (linha = 0; linha < m; linha++)
{
    somaLinha = 0;
    for (coluna = 0; coluna < n; coluna++)
    {
        somaLinha = somaLinha + matriz[linha, coluna];
        Console.Write(matriz[linha, coluna].ToString().PadLeft(4));
    }
    Console.Write($"  Soma: {somaLinha}");

    Console.WriteLine();
}