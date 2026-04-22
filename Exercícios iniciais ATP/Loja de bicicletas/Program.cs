namespace LojadeBicicletas;
public class Program
{
    public static void Main()
    {
        double salMin, comissao, pCusto, salFinal, lucro, pVenda;
        int qteFunc, vBike;
        Console.WriteLine("Qual a quantidade de funcionários?: ");
        qteFunc = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o valor do salário?: ");
        salMin = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o preço de custo das bicicletas?: "); 
        pCusto = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantas bicicletas foram vendidas?: ");
        vBike = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Qaual o valor de venda das bicicletas?: ");
        pVenda = double.Parse(Console.ReadLine());
        comissao = pCusto * vBike * 1.15;
        salFinal = salMin * 2 + (comissao - pCusto) / qteFunc;
        lucro = vBike * pVenda * 1.50 - pCusto - salFinal;
        Console.WriteLine($"O salário final de cada empregado é: {salFinal}");
        Console.WriteLine($"O lucro líquido é: {lucro}");
    }
}
