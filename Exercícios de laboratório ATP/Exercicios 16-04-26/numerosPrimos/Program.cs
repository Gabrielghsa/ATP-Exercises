int n, i, div = 0;
Console.Write("Informe um valor: ");
n = int.Parse(Console.ReadLine());

for (i = 1; i <= n; i++)
{
    if (n % i == 0)
        div = div + 1;
}
if (div == 2)
{
    Console.Write($"O número {n} é primo");
}
else
{
    Console.Write($"O número {n} não é primo");

}
