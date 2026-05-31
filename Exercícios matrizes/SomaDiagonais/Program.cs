int n, linha,coluna, somaDP = 0, somaDA = 0, somaDC = 0, somaElementos = 0;
int[,] matriz;
Console.Write("Informe as dimensões da da matriz quadrada");
n = int.Parse(Console.ReadLine());
matriz = new int[n,n];

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
    
    for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        somaElementos = somaElementos + matriz[linha,coluna];
        if(linha == coluna)
        {
            somaDP = somaDP + matriz[linha, linha];
        }else if(linha > coluna)
        {
            somaDA = somaDA + matriz[linha,coluna];
        }else if(linha < coluna)
        {
            somaDC = somaDC + matriz[linha, coluna];
        }
        Console.Write(matriz[linha, coluna].ToString().PadLeft(4));

    }
    Console.WriteLine();
}
Console.WriteLine($"A soma dos elementos da matriz é: {somaElementos}");
Console.WriteLine($"A soma da diagonal principal é: {somaDP}");
Console.WriteLine($"A soma da diagonal abaixo da principal é: {somaDA}");
Console.WriteLine($"A soma da diagonal acima da principal é: {somaDC}");