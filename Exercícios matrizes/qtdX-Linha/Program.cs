int m, n, x, i, j, linha, coluna, qtdXLinhas = 0, qtdXColunas = 0;
int[,] matriz;

Console.Write("Informe a qtd de linhas: ");
m = int.Parse(Console.ReadLine());
Console.Write("Informe a qtd de colunas: ");
n = int.Parse(Console.ReadLine());
matriz = new int[m,n];

for(linha = 0; linha < m; linha++)
{
    for(coluna = 0; coluna < n; coluna++)
    {
        Console.Write($"Digite o valor da posição [{linha},{coluna}]°");
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Informe um número X para ser procurado: ");
x = int.Parse(Console.ReadLine());
Console.Write("Informe em qual a linha: ");
i = int.Parse(Console.ReadLine());
Console.Write("Informe em qual coluna: ");
j = int.Parse(Console.ReadLine());


for(linha = 0; linha < m; linha++)
{
    for(coluna = 0; coluna < n; coluna++)
    {
        //Contar nas linhas
        if(linha == i && matriz[linha,coluna] == x)
        {
            qtdXLinhas++;
        }
        //Contar nas colunas
        if(coluna == j && matriz[linha,coluna] == x)
        {
            qtdXColunas++;
        }
        Console.Write(matriz[linha, coluna].ToString().PadLeft(4));
    }
    Console.WriteLine();
}
Console.WriteLine($"\nO número {x} aparece {qtdXLinhas} vez(es) na linha {i}");
Console.WriteLine($"O número {x} aparece {qtdXColunas} vez(es) na coluna {j}");

