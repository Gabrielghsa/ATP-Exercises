int[] numeros, numPares, numImpares;
int n, valor, contPar = 0, contImpar = 0;

Console.Write("Informe a quantidade de valores: ");
n = int.Parse(Console.ReadLine());
numeros = new int[n];
numPares = new int[n];
numImpares = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Qual o {i + 1}° número: ");
    valor = int.Parse(Console.ReadLine());

    numeros[i] = valor;

    if (valor % 2 == 0)
    {
        numPares[contPar] = valor;
        contPar++;
    }
    else
    {
        numImpares[contImpar] = valor;
        contImpar++;
    }
}
Console.Write($"A lista de números é: {String.Join(", ", numeros)}");


Console.WriteLine($"Os numeros pares são:");
for (int j = 0; j < numPares.Length; j++)
{
    Console.Write(numPares[j] + " ");
}

 Console.WriteLine($"Os números ímpares são:");
for (int x = 0; x < numImpares.Length; x++)
{
    Console.Write(numImpares[x] + " ");
}


