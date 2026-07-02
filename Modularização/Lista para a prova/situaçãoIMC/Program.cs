using System; 
class Program
{

    static void situacaoIMC(double peso, double altura)
    {
        double imc = peso / Math.Pow(altura, 2);
        if(imc < 20)
        {
            Console.Write($"IMC: {imc:f2} abaixo do peso");
        }else if(imc >= 20 && imc < 25)
        {
            Console.Write($"IMC: {imc:f2} peso normal");
        } else if(imc >= 25 && imc <= 30)
        {
            Console.Write($"IMC: {imc:f2} sobrepeso");
        } else if(imc >=30 && imc <= 40)
        {
            Console.Write($"IMC: {imc:f2} obesidade");
        } else
        {
            Console.Write($"IMC: {imc:f2} obesidade mórbida");
        }
    }
    static void Main()
    {
        double peso, altura;
        Console.Write("Informe seu peso: ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("Informe sua altura: ");
        altura = double.Parse(Console.ReadLine());
        situacaoIMC(peso, altura);
    }

}

