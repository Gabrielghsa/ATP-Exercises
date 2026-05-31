/* int[] nums = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int i;

Console.WriteLine($"Vetor inicial: {string.Join(" - ", nums)}");
for(i = 0; i < nums.Length - 1; i++)
{
    nums[i] = nums[i+1];
}
nums[nums.Length - 1] = 0;
Console.WriteLine($"Vetor final: {string.Join(" - ", nums)}");
Console.WriteLine($"Tamanho final {nums.Length}");

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------");
/* Código para inserir um valor e deslocar os outros para "frente" */

/*int[] valores = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int j, numero = 99, indic = 7;
Console.WriteLine($"Vetor inicial: {string.Join(" - ", valores)}");
for(j = valores.Length - 1; j > indic; j--)
{
    valores[j] = valores[j - 1];
}
valores[indic] = numero;
Console.WriteLine($"Depois: {string.Join(" - ", valores)}"); */

Console.Write("Outro modo de fazer essa eliminação e liberação do último elemento");

int[] V = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int i;
int tamanhoDoVetor = V.Length;

Console.WriteLine($"Vetor inicial: {string.Join(" - ", V)}");

for(i = 0; i < V.Length - 1; i++)
{
    V[i] = V[i + 1];
}
tamanhoDoVetor--; //Reduzindo o tamanho do vetor

Console.Write("Vetor final: ");

for(i = 0; i < tamanhoDoVetor; i++)
{
    Console.Write(V[i] + " " );
}