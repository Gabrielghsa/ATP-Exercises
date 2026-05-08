//Escrever as potências de 2 menores que n;
int n, i = 0;
double pot;

Console.Write("Informe o valor de n: ");
n = int.Parse(Console.ReadLine());

pot = Math.Pow(2, i);

while(pot < n)
{
    Console.WriteLine($"2^{i} = {pot}");
    i++;
    pot = Math.Pow(2, i);
}