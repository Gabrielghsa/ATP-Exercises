using System;
    class MaiorMenor
{
    static void Main()
    {
        int firstNumber, secondNumber;
        Console.WriteLine("Qual o primeiro número: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o segundo número: ");
        secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"O valor {firstNumber} é maior ");
        } else if(firstNumber < secondNumber)
        {
            Console.WriteLine($"O valor {secondNumber} é maior");
        } else
        {
            Console.WriteLine("Os valores são iguais");
        }
        
    }
}
