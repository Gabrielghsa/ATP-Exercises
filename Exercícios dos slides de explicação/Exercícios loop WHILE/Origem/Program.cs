using System;
    public class Program
{
        public static void Main()
    {
        double preco;
        int codProc;
        string origem;
        Console.WriteLine("Qual o preço do produto?: ");
        preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o código de procedência do produto?: ");
        codProc = int.Parse(Console.ReadLine());

       if (codProc == 1)
        {
            origem = "Sul";
            
        }else if (codProc == 2)
        {
            origem = "Norte";
           
        }else if (codProc == 3)
        {
            origem = "Leste";
            
        }else if (codProc == 4)
        {
            origem = "Oeste";
            
        }else if (codProc == 5 || codProc == 6)
        {
            origem = "Nordeste";
           
        }else if (codProc == 7 || codProc == 8 || codProc == 9)
        {
            origem = "Sudeste";
            
        }else
        {
            origem = "Produto importado";
        }
        Console.WriteLine($"O preço é {preco}");
        Console.Write(origem);
    }    
}
