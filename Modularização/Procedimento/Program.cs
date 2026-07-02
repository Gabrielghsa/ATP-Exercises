//Procedimento não retorna valor, apenas a função faz esse retorno com possibilidade de usar em outras partes esse retorno

using System;
class Program
{
    static void MostrarNome (string nome)
    {
        Console.Write("Bem-Vindo " + nome); //Só mostra na tela, não retorna nada
    }
    static void Main()
    {
        Console.Write("Qual o seu nome?: ");
        string nome = Console.ReadLine();
        MostrarNome(nome); 
    }
}

