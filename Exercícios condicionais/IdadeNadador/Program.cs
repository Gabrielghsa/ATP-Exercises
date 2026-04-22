using System;    
namespace IdadeNadador;
class Program
{
    static void Main()
    {
        int idade;
        string categoria = "";
        Console.WriteLine("Qual a sua idade?: ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            categoria = "Sênior";

        } else if (idade >= 5 && idade <= 7)
        {
            categoria = "Infantil A";

        } else if (idade >= 8 && idade < 11)
        {
            categoria = "Infatil B"; 

        }else if (idade >= 11 && idade <= 13)
        {
            categoria = "Juvenil A";

        }else if (idade >= 14 && idade < 18)
        {
            categoria = "Juvenil B";
        }
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Categotia: {categoria}");
    }
}
