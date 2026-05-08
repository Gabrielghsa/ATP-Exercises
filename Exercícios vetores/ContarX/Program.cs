int n, i, x, y, contX = 0;
int[] v;

Console.Write("Informe a quantidade de valores: ");
n = int.Parse(Console.ReadLine());

v = new int[n];
for(i = 0; i < v.Length; i++)
{
    Console.Write($"Informe o {i + 1} valor: ");
    v[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Informe um número: ");
x = int.Parse(Console.ReadLine());
//Verificando quantas vezes um número x aparece no vetor;
for(i = 0; i < v.Length; i++)
{
    if(x == v[i])
    {
        contX++;
    }
}

//Verificando se um número x existe no vetor;
Console.WriteLine("Informe outro valor para verificar se ele existe na lista: ");
y = int.Parse(Console.ReadLine());
bool encontrou = false;
for(i = 0; i < v.Length; i++)
{
   if(v[i] == y)
    {
        encontrou = true;
        break;
    }
}
if (encontrou)
{
    Console.WriteLine($"O número existe na lista");
}else
{
    Console.WriteLine($"O número não existe na lista");
}
Console.Write($"O número {x} aparece {contX} vezes");
