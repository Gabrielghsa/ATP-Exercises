/*
    Entrar com valores do salário e das horas extras
    calcular o rendimento mensal a partir das seguintes regras
        1° de 1 a 10 horas extras o valor de cada hora extra é 1% do salário base
        2° de 11 a 20 //    //    //   //   //   //    //      2% do salário base 
        3° acima de 20                  //                     3% do salário base  
*/      
using System; 
class Program
{
    static void Main()
    {
         double  qtdHoraEx, salBase, horaEx, salFinal;
         
        Console.WriteLine("Qual o valor do salário base?: ");
        salBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a quantidade de horas extras feitas no mês?: ");
        qtdHoraEx = double.Parse(Console.ReadLine());

        if (qtdHoraEx >= 1 && qtdHoraEx <= 10)
        {
            horaEx = salBase * 0.01;
        } else if (qtdHoraEx > 10 && qtdHoraEx <= 20)
        {
            horaEx = salBase * 0.02;
        } else
        {
            horaEx = salBase * 0.03;
        }
        salFinal = salBase + horaEx;

        Console.WriteLine($"Você fez: {qtdHoraEx} de horas extras");
        Console.WriteLine($"Seu salário base é: {salBase}");
        Console.WriteLine($"O valor de suas horas extras é: {horaEx:f2}");
        Console.WriteLine($"O valor final a receber é: {salFinal}");
    }
}