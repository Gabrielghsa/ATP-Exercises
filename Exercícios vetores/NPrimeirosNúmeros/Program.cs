int n, i, contPar = 0, contImpar = 0;
int[] vPar, vImpar, v;

Console.Write("Informe um número inteiro n: ");
n = int.Parse(Console.ReadLine());
v = new int[n];


for(i = 0; i < v.Length; i++)
{
    v[i] = i;
    if(v[i] % 2 == 0)
    {
        contPar++;
    }else
    {
        contImpar++;
    }
}
vPar = new int[contPar];
vImpar = new int[contImpar];

contPar = 0;
contImpar = 0;
for(i = 0; i < v.Length; i++)
{
    if(v[i] % 2 == 0)
    {
        vPar[contPar] = v[i];
        contPar++;
    }else
    {
        vImpar[contImpar] = v[i];
        contImpar++;
    }
}
Console.WriteLine($"A lista de números é: {string.Join("-", v)}");
Console.WriteLine($"A lista de números pares é: {string.Join("-", vPar)}");
Console.Write($"A lista de números ímpares é: {string.Join("-", vImpar)}");
