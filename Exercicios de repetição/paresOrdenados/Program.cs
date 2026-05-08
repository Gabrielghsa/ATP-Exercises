//Escrevendo os valores até n em pares ordenados;
int n;
Console.Write("Informe o valor de n: ");
n = int.Parse(Console.ReadLine());

for(int x = 0; x <= n; x++)
{
   Console.WriteLine($"{x},{x}");
}
