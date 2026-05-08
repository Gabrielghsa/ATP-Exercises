//Escrever todos os números positivos, pares e impares até n;

int n;

Console.Write("Informe o valor de n: ");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Números inteiros positivos:");
for (int i = 1; i <= n; i++)
{
    Console.Write(i + " ");
    
}

Console.WriteLine();

Console.WriteLine("Números pares:");
for (int j = 1; j <= n; j++)
{
    Console.Write(j * 2 + " ");
    
}

Console.WriteLine();

Console.WriteLine("Números ímpares: ");
for (int k = 1; k <= n; k++)
{
    Console.Write(k * 2-1 + " ");
    
}
