/* Faça um algoritmo em C# que:
(a) leia do teclado o valor de uma compra e o valor em dinheiro dado pelo comprador;
(b) calcule e escreva o valor do troco a receber.*/
using System;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        double valCompra, valRecebido, troco;

        Console.Write("Qual o valor da compra efetuada?: ");
        valCompra = double.Parse(Console.ReadLine());
        Console.Write("Qual o valor recebido para efetuar o pagamento?: ");
        valRecebido = double.Parse(Console.ReadLine());

        troco = valRecebido - valCompra;

        Console.Write($"O cliente deve receber R${troco} de troco.");
    } 
}