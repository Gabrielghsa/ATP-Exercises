int q1, q2, i, j;
int[] v1, v2;

Console.Write("Informe um número inteiro: ");
q1 = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------");
Console.Write("Informe um número inteiro: ");
q2 = int.Parse(Console.ReadLine());
v1 = new int[q1];
v2 = new int[q2];


for (i = 0; i < v1.Length; i++)
{
    Console.Write($"Informe o {i + 1}° número de v1: ");
    v1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("-------------------------");
for (i = 0; i < v2.Length; i++)
{
    Console.Write($"Informe o {i + 1}° número de v2: ");
    v2[i] = int.Parse(Console.ReadLine());
}
bool maior = false;
for (i = 0; i < v1.Length; i++)
{
    for (j = 0; j < v2.Length; j++)
    {
        if (v1[i] > v2[j])
        {
            maior = true;
            break;
        }
    }
    Console.Write($"{" " + v1[i]}");
}




