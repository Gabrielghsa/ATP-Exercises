int[] v = new int[]{5, 6, 2, 5, 9, 1, 4, 4, 5, 4 };
int i, x = 4, cont = 0;
for(i = 0; i < v.Length; i++)
{
    if(x == v[i])
        cont++;
}

Console.Write($"O número {x} aparece {cont} vezes");