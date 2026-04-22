/*Façaa um algoritmo em C# que:
(a) leia o nome, a data de nascimento e idade de uma pessoa.
(b) escreva os valores na tela.
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        //Armazenando os valores do usário
        string nome;
        int idade, data;

        DateOnly datanasc = new DateOnly(2002, 06, 06);// Tipo especifico para datas; 

        //Entrada de dados
         Console.Write("Qual o seu nome? ");
         nome = Console.ReadLine();
         Console.Write("Qual a sua data de nascimento? ");
         data = int.Parse(Console.ReadLine());
         Console.Write("Qual a sua idade?");
         idade = int.Parse(Console.ReadLine());

        //Saída de dados
        Console.WriteLine($"Seu nome é: {nome}");
        Console.WriteLine($"Sua data de nascimento é: {data}");
        Console.WriteLine($"Sua idade é: {idade}");
        Console.WriteLine($"Sua data de nascimento é: {datanasc}");

    }
}