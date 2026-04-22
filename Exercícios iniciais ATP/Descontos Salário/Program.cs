// Calcular descontos de INSS e desconto de IR 
using System; 
class Program
{
    static void Main()
    {
         
        double inssDesc = 0, impRenda = 0, salBruto, salLiqui, salDesInss, salDescIr;
        Console.WriteLine("Informe seu salário bruto: ");
        salBruto = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o percentual de desconto do INSS: ");
        inssDesc = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o percentual de desconto do IR: ");
        impRenda = double.Parse(Console.ReadLine());
        salDesInss = salBruto * inssDesc / 100;
        salDescIr = salBruto * impRenda / 100;

        salLiqui = salBruto - salDesInss - salDescIr;

        Console.WriteLine($"O salário bruto é: {salBruto}");
        Console.WriteLine($"O desconto do INSS é: {salDesInss:f2}");
        Console.WriteLine($"O desconto de IR é: {salDescIr:f2}");
        Console.WriteLine($"O salário liquído é: {salLiqui:f2}");

    }
}