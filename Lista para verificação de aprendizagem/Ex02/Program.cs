/*Faça um algoritmo em C# que:
(a) armazene em três variáveis: seu nome, sua data de nascimento e sua idade.
(b) escreva os valores das trˆes variáveis.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        //Armazenando os dados
        string nome = "Gabriel", data = "06/06/2002";
        int idade = 23;
        //Saída de dados
        Console.WriteLine($"Seu nome é: {nome}");
        Console.WriteLine($"Sua data de nascimento é: {data}");
        Console.WriteLine($"Sua idade é: {idade}");
    }
}
