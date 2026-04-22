/*
using System;
class Program
{
    static void Main()
    {
        //Feito por mim
        int num1, num2, num3, num4, soma, media, maior, menor, par = 0, impar = 0, positivo = 0, negativo = 0, nulo = 0;

        Console.WriteLine("Qual é o primeiro número:"); 
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o segundo número:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o terceiro número:");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o quarto número:"); 
        num4 = int.Parse(Console.ReadLine());
        soma = num1 + num2 + num3 + num4;
        media = soma / 4;

        maior = num1;
        if (num2 > maior)
        {
            maior = num2;
        }
        if (num3 > maior)
        {
            maior = num3;
        } 
        if  (num4 > maior)
        {
            maior = num4;
        }

        menor = num1;
        if (num2 < menor)
        {
            menor = num2;
        }
        if (num3 < menor)
        {
            menor = num3;
        } 
        if  (num4 < menor)
        {
            menor = num4;
        }
       
        //Pares 
       if (num1 % 2 == 0)
        {
            par += 1;
        }else
        {
            impar += 1; 
        }

       if (num2 % 2 == 0)
        {
            par += 1;
        }else
        {
            impar += 1; 
        }

       if (num3 % 2 == 0)
        {
            par += 1;
        }else
        {
            impar += 1; 
        }

       if (num4 % 2 == 0)
        {
            par += 1;
        }else
        {
            impar += 1; 
        }

       
        
        if (num1 > 0)
        {
            positivo += 1;
        }else if (num1 < 0)
        {
            negativo += 1;
        }else
        {
            nulo += 1;
        }

        if (num2 > 0)
        {
            positivo += 1;
        }else if (num2 < 0)
        {
            negativo += 1;
        }else
        {
            nulo += 1;
        }

        if (num3 > 0)
        {
            positivo += 1;
        }else if (num3 < 0)
        {
            negativo += 1;
        }else
        {
            nulo += 1;
        }

        if (num4 > 0)
        {
            positivo += 1;
        }else if (num4 < 0)
        {
            negativo += 1;
        }else
        {
            nulo += 1;
        }

        Console.WriteLine($"A soma dos números é: {soma}");
        Console.WriteLine($"A média dos números é: {media}");
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"A quantidade de números pares é: {par}");
        Console.WriteLine($"A quantidade de números ímpares é: {impar}");
        Console.WriteLine($"A quantidade de números positivos é: {positivo}");
        Console.WriteLine($"A quantidade de números negativos é: {negativo}");
        Console.WriteLine($"A quantidade de números nulos é: {nulo}");
        


    }
}*/

//Refatorado pelo GPT 
using System;


class Program
{
    static void Main()
    {
        int[] numeros = new int[4];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        int par = 0, impar = 0;
        int positivo = 0, negativo = 0, nulo = 0;

        int maior = numeros[0];
        int menor = numeros[0];

        foreach (int num in numeros)
        {
            soma += num;

            // Maior e menor
            if (num > maior) maior = num;
            if (num < menor) menor = num;

            // Par ou ímpar
            if (num % 2 == 0)
                par++;
            else
                impar++;

            // Positivo, negativo ou zero
            if (num > 0)
                positivo++;
            else if (num < 0)
                negativo++;
            else
                nulo++;
        }

        int media = soma / numeros.Length;

        Console.WriteLine($"\nSoma: {soma}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
        Console.WriteLine($"Pares: {par} | Ímpares: {impar}");
        Console.WriteLine($"Positivos: {positivo} | Negativos: {negativo} | Zeros: {nulo}");
    }
}
