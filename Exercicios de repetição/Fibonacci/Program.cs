int a = 0, b = 1, numAtual, n = 10;

for(int i = 1; i <= n; i++)
{
    Console.Write(a + " ");
    numAtual = a;
    a = b;
    b = numAtual + b;

}
