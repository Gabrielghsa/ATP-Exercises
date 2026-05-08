int n = 5, soma = 0;
for (int i = 0; i < n; i++)
{
    for(int j = i + 1; j < 4; j++)
    {
         soma = soma + (i*j);
        Console.WriteLine(soma);
    }
}