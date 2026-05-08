int[] numeros;
int n, qtdPar = 0, qtdImpar = 0, indicePar = 0, indiceImpar = 0;
Console.Write("Infrome a quantidade de números: ");
n = int.Parse(Console.ReadLine());
numeros = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Informe o {i + 1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

//Contando quantos números são pares e ímpares para criar os vetores com o tamanho correto
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        qtdPar++;
    }
    else
    {
        qtdImpar++;
    }
}
int[] numPares = new int[qtdPar];
int[] numImpares = new int[qtdImpar];

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        numPares[indicePar] = numeros[i];
        indicePar++;
    }
    else
    {
        numImpares[indiceImpar] = numeros[i];
        indiceImpar++;
    }
}
Console.WriteLine($"A lista de números é: {string.Join(", ", numeros)}");
Console.WriteLine($"Números pares são: {string.Join(", ", numPares)}");
Console.WriteLine($"Números ímpares são: {string.Join(", ", numImpares)}");
