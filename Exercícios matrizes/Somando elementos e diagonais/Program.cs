int n, l, c, somaElementos = 0, somaDP = 0, somaDAbaixo = 0, somaDAcima = 0;
int[,] matriz;

Console.Write("Informe o tamanho das linhas e colunas da matriz quadrada: ");
n = int.Parse(Console.ReadLine());
matriz = new int[n, n];

for (l = 0; l < n; l++)
{
    for (c = 0; c < n; c++)
    {
        Console.Write($"Digite o valor da posição [{l},{c}]°");
        matriz[l, c] = int.Parse(Console.ReadLine());
    }
}

for (l = 0; l < n; l++)
{
    for (c = 0; c < n; c++)
    {
        somaElementos = somaElementos + matriz[l, c];
        if (l == c)
        {
            somaDP = somaDP + matriz[l, l];
        }
        else if (l > c)
        {
            somaDAbaixo = somaDAbaixo + matriz[l, c];
        }
        else if (l < c)
        {
            somaDAcima = somaDAcima + matriz[l, c];
        }

        Console.Write(matriz[l, c].ToString().PadLeft(4));
    }
    Console.WriteLine();
}
Console.WriteLine($"A soma dos elementos da matriz é: {somaElementos}");
Console.WriteLine($"A soma da diagonal principal é: {somaDP}");
Console.WriteLine($"A soma da diagonal abaixo da principal é: {somaDAbaixo}");
Console.WriteLine($"A soma da diagonal acima da principal é: {somaDAcima}");




