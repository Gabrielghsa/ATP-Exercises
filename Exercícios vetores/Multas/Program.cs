int n, i, qtdMultas = 0;
double soma = 0, media;
string[] placas;
double[] multas;

Console.Write("Informe a qtd de veículos: ");
n = int.Parse(Console.ReadLine());
placas = new string[n];
multas = new double[n];

for (i = 0; i < n; i++)
{
    Console.Write($"Informe a placa do {i + 1}° veículo: ");
    placas[i] = Console.ReadLine();
    Console.Write($"Informe o valor da multa do {i + 1}° veículo: ");
    multas[i] = double.Parse(Console.ReadLine());
    if (multas[i] > 0)
    {
        soma = soma + multas[i];
        qtdMultas++;
    }
}
media = (double)soma / qtdMultas;
Console.WriteLine($"Valor médio das multas: {media}");
for (i = 0; i < multas.Length; i++)
{

    if (multas[i] > media)
    {
        Console.Write($"O veículo de placa {placas[i]}");
        Console.WriteLine($" Possui multa com a valor acima da média: {multas[i]}");
    }

}


