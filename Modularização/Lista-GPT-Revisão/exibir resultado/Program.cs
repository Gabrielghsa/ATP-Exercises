using System; 
class Program
{

    static double Media(double nota1, double nota2)
    {
        double mediaFinal = (double)(nota1 + nota2) / 2;
        return mediaFinal;
    }

    static void ExibirResultado(string nome, double mediaFinal)
    {
        Console.WriteLine($"Aluno: {nome}");
        Console.Write($"Media: {mediaFinal}");

    }

    static void Main()
    {
        Console.Write("Informe o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Informe a primeira nota aluno: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Informe a segunda nota do aluno: ");
        double nota2 = double.Parse(Console.ReadLine());

        double mediaFinal = Media(nota1, nota2);
        ExibirResultado(nome, mediaFinal);
    }
}
