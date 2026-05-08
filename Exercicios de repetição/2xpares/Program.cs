int num, qtdPares = 0, qtdImpares = 0;

do
{
    Console.Write("Informe um número: ");
    num = int.Parse(Console.ReadLine());

    if(num % 2 == 0)
    {
        qtdPares++;
    } else
    {
        qtdImpares++;
    }
    Console.WriteLine($"Qtde pares: {qtdPares}");
    Console.WriteLine($"Qtde ímpares: {qtdImpares}");
}while(qtdPares != 2*qtdImpares);
