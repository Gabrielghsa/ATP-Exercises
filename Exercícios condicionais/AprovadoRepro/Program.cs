using System;
    namespace AprovadoRepro;
        public class Program{
            public static void Main()
    {
        int nota;
        Console.WriteLine("Qual a nota do aluno?: ");
        nota = int.Parse(Console.ReadLine());
        if (nota >= 80)
        {
            Console.WriteLine("Aprovado");
        } else if (nota >= 60)
        {
            Console.WriteLine("Aprovado mas precisa estudar mais");
        }else
        {
            Console.WriteLine("Reprovado");
        }
    }
        }
