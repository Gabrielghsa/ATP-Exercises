int[] numeros, numPares, numImpares;
int n, valor;

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
        Array.Resize(ref numPares, numPares.Length + 1);
        numPares[numPares.Length - 1] = valor;
    }
    else
    {
        Array.Resize(ref numImpares, numImpares.Length + 1);
        numImpares[numImpares.Length - 1] = valor;
    }
}
Console.WriteLine($"A lista de números é: {string.Join(", ", numeros)}");
Console.WriteLine($"Números pares são: {string.Join(", ", numPares)}");
Console.WriteLine($"Números ímpares são: {string.Join(", ", numImpares)}");


