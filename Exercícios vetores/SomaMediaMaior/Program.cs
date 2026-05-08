//Algoritmo para calcular a média e contar quantos são acima da média;
int n, soma = 0, qtdAcimaMed = 0;
double media;
int[] v, numAcima;


Console.Write("Informe a quantidade de números que serão calculados: ");
n = int.Parse(Console.ReadLine());

v = new int[n];
//Populando o vetor e somando os valores;
for(int i = 0; i < v.Length; i++)
{
    Console.Write($"Informe o {i + 1} número: ");
    v[i] = int.Parse(Console.ReadLine());
    soma = soma + v[i];
}

media = (double)soma / v.Length;

//Verificando quantos são acima da media;
for(int i = 0; i < v.Length; i++)
{
    if(v[i] > media)
    {
        qtdAcimaMed++;
    }
}
numAcima = new int[v.Length];

for(int i = 0; i < v.Length; i++)
{
    for(int j = 0; j < numAcima.Length; j++)
    {
        if(v[i] > media)
        {
            numAcima[i] = v[i];
        }
    }
}
Console.WriteLine($"A média é: {media}");
Console.WriteLine($"A quantidade de números acima da média é: {qtdAcimaMed}");
Console.WriteLine($"O números acima da média são: {string.Join(" ", numAcima)}");
Console.Write($"O números da lista são: {string.Join(", ", v)}");






