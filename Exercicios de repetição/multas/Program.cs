double mediaMultas = 0, somaMultas = 0, valor;
int qtdVeiculos = 0;


do
{
    Console.Write("Informe o valor da multa: ");
    valor = double.Parse(Console.ReadLine());
    if (valor >= 0)
    {
        somaMultas = somaMultas + valor;
        qtdVeiculos++;
    }
} while (valor >= 0);
if (qtdVeiculos > 0)
{
    mediaMultas = (double)somaMultas / qtdVeiculos;
}
Console.WriteLine($"A soma das multas é: {somaMultas}");
Console.WriteLine($"A média das multas é: {mediaMultas}");
Console.Write($"A quantidade de veículos é: {qtdVeiculos}");
