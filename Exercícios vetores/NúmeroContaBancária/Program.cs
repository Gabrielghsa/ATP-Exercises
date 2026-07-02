int somaProd = 0, i, digito;
int[] numConta = new int[5] {2,3,4,7,4};
int[] sequencia = new int[5] {5,6,7,8,9};

for(i = 0; i < numConta.Length; i++)
{
    somaProd = somaProd + numConta[i] * sequencia[i];
}
digito = somaProd % 10;
Console.Write($"O digito é: {digito}");


