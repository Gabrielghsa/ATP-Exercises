using System;
class Program
{
    static void Main(string[] args)
    {
        //Usando List<T>
        List<int> numeros = new List<int>();
        List<int> numPares = new List<int>();
        List<int> numImpares = new List<int>();
        int n, valor;

        Console.Write("Informe a quantiadade de números: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Qual o {i + 1}° número: ");
            valor = int.Parse(Console.ReadLine());

            numeros.Add(valor);
            if (valor % 2 == 0)
            {
                numPares.Add(valor);
            }
            else
            {
                numImpares.Add(valor);
            }
        }
        Console.WriteLine($"A lista de números é: {string.Join(", ", numeros)}");
        Console.WriteLine($"Números pares são: {string.Join(", ", numPares)}");
        Console.WriteLine($"Números ímpares são: {string.Join(", ", numImpares)}");
    }
}


