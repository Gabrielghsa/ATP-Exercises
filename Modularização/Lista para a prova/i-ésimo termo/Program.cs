//3*5 elevado a 3¨¨1, 3¨¨2...
using System; 
class Program
{

    static double termo(int i)
    {
        double numerador = Math.Pow(2, i - 1);
        double expoente = Math.Pow(3, i - 1);
        double denominador = 3 * Math.Pow(5, expoente);

        return numerador/denominador;
    }

    static void mostraSequencia(int n)
    {
        int i;
        for(i = 1; i <= n; i++)
        {
            Console.WriteLine(termo(i));
        }   
    }

    static double somaTermos(int n)
    {
        int i;
        double somaTermo = 0;
        for(i = 1; i <= n; i++)
        {
            somaTermo = somaTermo + termo(i);
        }
        return somaTermo;
    }
    static void Main()
    {
        int n;
        Console.Write("Informe o i-ésimo termo: ");
        n = int.Parse(Console.ReadLine());
        /* mostraSequencia(n); */
        /* Console.Write($"Termo {i}: {termo(i)}"); */
        Console.Write($"A soma é: {somaTermos(n)}");

    }
} 
