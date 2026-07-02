using System; 
class Program
{

    static double valorImc(double peso, double altura)
    {
        return peso / Math.Pow(altura, 2);
    }
    static void Main()
    {
        double peso, altura, imc;
        Console.Write("Informe seu peso: ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("Informe sua altura: ");
        altura = double.Parse(Console.ReadLine());
        imc = valorImc(peso, altura);
        Console.Write($"Seu IMC é: {imc:f2}");
    }

}
