int n, tipoMov; 
double saldoInicial, saldoFinal, saida, entrada, saldoMovim;

Console.WriteLine("Qual o saldo inicial da conta?: ");
saldoInicial = double.Parse(Console.ReadLine());
Console.Write("Quantos lançamentos a conta realizou?: ");
n = int.Parse(Console.ReadLine());
saldoFinal = saldoInicial;
for(int j = 1; j <= n; j++)
{
    Console.Write("Qual o tipo de transação?: 1(Débito) 2(Crédito)");
    tipoMov = int.Parse(Console.ReadLine());

    if(tipoMov == 1)
    {
        Console.Write("Qual o valor que foi debitado?: ");
        saldoMovim = double.Parse(Console.ReadLine());
        saldoFinal -= saldoMovim;
    } else if(tipoMov == 2)
    {
        Console.Write("Qual o valor que foi creditado?: ");
        saldoMovim = double.Parse(Console.ReadLine());
        saldoFinal += saldoMovim;
    }
}

Console.WriteLine($"O saldo final é: {saldoFinal:f2}");
