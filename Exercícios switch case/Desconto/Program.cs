using System;

class Program
{
    static void Main()
    {
        string codIdentificador;
        double totalComp, desconto, valorFinal ;
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Loja de roupas");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Tipos de clientes: F-Cliente recorrente 5% de desconto");
        Console.WriteLine("Tipos de clientes: E-Cliente Premium 10% de desconto");
        Console.WriteLine("Tipos de clientes: C-Cliente comum sem desconto desconto");

        Console.WriteLine("Qual foi o valor total da compra?: ");
        totalComp = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o código identificador do cliente?: ");
        codIdentificador = Console.ReadLine() ??"";

        switch (codIdentificador)
        {
            case "F":
                desconto = totalComp * 0.05;
                valorFinal = totalComp - desconto;
                Console.WriteLine($"O valor total da compra foi {totalComp} e com o desconto ficou {valorFinal}");
                break;

            case "E":
                desconto = totalComp * 0.10;
                valorFinal = totalComp - desconto;
                Console.WriteLine($"O valor total da compra foi {totalComp} e com o desconto ficou {valorFinal}");
                break;

            case "C":
                Console.WriteLine($"O cliente não tem desconto. O valor da compra é: {totalComp}");
                break;
            
            default:
                Console.WriteLine("Código inválido!!!");
                break;
        }




    }
}
