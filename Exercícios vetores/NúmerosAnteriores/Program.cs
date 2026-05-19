int n, contPares = 0, contImpares = 0;
int[] numeros;
Console.Write("Informe um número: ");
n = int.Parse(Console.ReadLine());

numeros = new int[n];
for(int i = 0; i < numeros.Length; i++)
{
    numeros[i] = i;
    if(i % 2 == 0)
    {
        contPares++;
    }else
    {
        contImpares++;
    }
}
int[] pares = new int[contPares];
int[] impares = new int[contImpares];
contPares = 0;
contImpares = 0;

for(int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] % 2 == 0)
    {
        pares[contPares] = numeros[i];
        contPares++;
    }else
    {
        impares[contImpares] = numeros[i];
        contImpares++;
    }
}
Console.WriteLine($"A lista de números é: {string.Join("-", numeros)}");
Console.WriteLine($"Os números pares são: {string.Join("-", pares)}");
Console.Write($"Os números ímpares são: {string.Join("-", impares)}");


