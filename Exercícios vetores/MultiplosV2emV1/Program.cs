

int q1, q2, qtdMult, i, j;
int[] v1, v2;

Console.Write("Informe o tamanho de v1: ");
q1 = int.Parse(Console.ReadLine());
Console.Write("Informe o tamanho de v2: ");
q2 = int.Parse(Console.ReadLine());
v1 = new int[q1];
v2 = new int[q2];

for(i = 0; i < v1.Length; i++)
{
    Console.Write($"Informe o {i+1}° número do vetor v1: ");
    v1[i] = int.Parse(Console.ReadLine());
}
for(j = 0; j < v2.Length; j++)
{
    Console.Write($"Informe o {j+1}° número do vetor v2: ");
    v2[j] = int.Parse(Console.ReadLine());
}

for(i = 0; i < v1.Length; i++)
{
    qtdMult = 0;
    for(j = 0; j < v2.Length; j++)
    {
        if(v1[i] % v2[j] == 0)
        {
            qtdMult++;
        }
    }
    if(qtdMult == v2.Length)
    {
        Console.WriteLine($"O número {v1[i]} é múltiplo de todos os números de v2;");
    }
}