using System; 
class Program
{

    static double valorHipotenusa(double catOp, double catAdj)
    {
        //Fazendo por partes
        /* double hipTemp = Math.Pow(catOp, 2) + Math.Pow(catAdj, 2);
        double hipotenusa = Math.Sqrt(hipTemp);
        return hipotenusa; */

        //Fazendo direto
        return Math.Sqrt(Math.Pow(catOp, 2) + Math.Pow(catAdj, 2));
    }
    static void Main()
    {
        double catOp, catAdj;
        Console.Write("Informe o valor do cateto oposto: ");
        catOp = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor do cateto adjacente : ");
        catAdj = double.Parse(Console.ReadLine());

        Console.Write($"O valor da hipotenusa é: {valorHipotenusa(catOp, catAdj)}");


    }
}
