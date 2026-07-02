int n, i;
double somaN = 0;
double[] valores;

Console.Write("Informe o número de termos que a sequência terá: ");
n = int.Parse(Console.ReadLine());
valores = new double[n];

for(i = 0; i < valores.Length; i++)
{
    valores[i] = Math.Sqrt(2*(i+1)) / Math.Pow(i+1, 2);
    somaN = somaN + valores[i];
}
/* Console.WriteLine($"{string.Join(" ", valores)}"); */

foreach(double valor in valores)
{
    Console.Write($"{valor:F4} ");
}
Console.Write($"A soma dos valores do vetor é: {somaN}");