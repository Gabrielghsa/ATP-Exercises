int i;
double[] pesos = new double[5];
double mediaPesos, soma = 0; 

for(i = 0; i < pesos.Length; i++)
{
    Console.Write($"Informe o peso da {i+1}° pessoa: ");
    pesos[i] = double.Parse(Console.ReadLine());
    soma = soma + pesos[i];
}
mediaPesos = (double)soma / pesos.Length;
Console.WriteLine($"A média de pesos é: {mediaPesos:f1}");
Console.WriteLine($"A lista de pesos é: {string.Join(" - ", pesos)}");

for(i = 0; i < pesos.Length; i++)
{
    if(pesos[i] < mediaPesos)
    {
        Console.WriteLine($"O peso na posição {i+1} está abaixo da média;");
    }
}
