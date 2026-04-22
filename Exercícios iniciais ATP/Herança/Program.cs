namespace Herança;
public class Program
{
    public static void Main()
    {
        int idade1, idade2, idade3, somaIdade;
        double vHeranca;
        Console.WriteLine("Qual o valor da herança?: ");
        vHeranca = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a idade do irmão mais novo?: ");
        idade1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a idade do irmão do meio?: ");
        idade2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a idade do irmão mais velho?: ");
        idade3 = int.Parse(Console.ReadLine());

        somaIdade = idade1 + idade2 + idade3;
        double irmao1= (double)idade1 / somaIdade * vHeranca;
        double irmao2 = (double)idade2 / somaIdade * vHeranca;
        double irmao3 = (double)idade3 / somaIdade * vHeranca;

        Console.WriteLine($"O irmão mais novo recebe: {irmao1}");
        Console.WriteLine($"O irmão do meio recebe: {irmao2}");
        Console.WriteLine($"O irmão mais velho recebe: {irmao3}");
    }
}//Corrija isso aqui

