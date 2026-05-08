//Sistema de caixa eletrônico Saque, Deposito, Pagamento de conta e Transfêrencia

using System;
class Program
{
    static void Main()
    {
        decimal saldo, saldoFinal;
        string op = "";
        Console.WriteLine("Qual o saldo da sua conta");
        saldo = decimal.Parse(Console.ReadLine());

        while (op != "0")
        {
            Console.Clear();
            Console.WriteLine("1-Saque");
            Console.WriteLine("2-Deposito");
            Console.WriteLine("3-Pagamento de Conta");
            Console.WriteLine("4-Tranferência");
            Console.WriteLine("0-Sair");

            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine("Qual o valor do saque");
                    decimal saque = decimal.Parse(Console.ReadLine());
                    saldoFinal = saldo - saque;
                    Console.WriteLine($"Seu saldo final após o saque é: R${saldoFinal:f2}");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Qual o valor você deseja depositar?: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    saldoFinal = saldo + deposito;
                    Console.WriteLine($"Seu saldo final após o deposito é: R${saldoFinal:f2}");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Digite o valor do boleto: ");
                    decimal boleto = decimal.Parse(Console.ReadLine());
                    saldoFinal = saldo - boleto;
                    Console.WriteLine($"Seu saldo final após o pagamento é: R${saldoFinal:f2}");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine($"Qual o valor você deseja tranfereir?: ");
                    decimal trans = decimal.Parse(Console.ReadLine());
                    saldoFinal = saldo - trans;
                    Console.WriteLine($"Seu saldo final após a transferência é: R${saldoFinal:f2}");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Saindo.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
