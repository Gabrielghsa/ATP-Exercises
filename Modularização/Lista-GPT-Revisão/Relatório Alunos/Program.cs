using System;
using System.IO;
class Program
{

    static StreamReader arqEntrada = new StreamReader("dadosAlunos_in.txt");
    static StreamWriter arqSaida = new StreamWriter("dadosAlunos_out.txt");
    static double Media(double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    static string Situacao(double mediaFinal)
    {
        if(mediaFinal >= 7)
        {
            return "Aprovado";
        }else if(mediaFinal >= 5 && mediaFinal < 7)
        {
            return "Recuperação";
        }else
        {
            return "Reprovado";
        }
    }

    static void ExibirRelatorio(string nome, double mediaFinal, string Situacao)
    {
        Console.WriteLine("=====RELATÓRIO=====");
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {mediaFinal:f2}");
        Console.WriteLine($"Situação: {Situacao}");

        arqSaida.WriteLine("=====RELATÓRIO=====");
        arqSaida.WriteLine($"Aluno: {nome}");
        arqSaida.WriteLine($"Média: {mediaFinal:f2}");
        arqSaida.WriteLine($"Situação: {Situacao}");
    }

    static void ProcessarAluno()
    {
        /* Console.Write("Qual o nome do aluno: "); */
        for(int i = 0; i < 3; i++)
        {
        string nome = arqEntrada.ReadLine();
        /* Console.Write("Informe o valor da 1° nota: "); */
        double nota1 = double.Parse(arqEntrada.ReadLine());
        /* Console.Write("Informe o valor da 2° nota: "); */
        double nota2 = double.Parse(arqEntrada.ReadLine());
        /* Console.Write("Informe o valor da 3° nota: "); */
        double nota3 = double.Parse(arqEntrada.ReadLine());
        Media(nota1, nota2, nota3);
        double mediaFinal = Media(nota1, nota2, nota3);
        Situacao(mediaFinal);
        string situacaoAluno = Situacao(mediaFinal);
        ExibirRelatorio(nome, mediaFinal, situacaoAluno);
        }
    }
    static void Main()
    {
        ProcessarAluno();
        arqEntrada.Close();
        arqSaida.Close();
    }
}
