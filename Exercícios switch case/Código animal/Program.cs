using System;
class Program
{
    static void Main()
    {
        int codAnimal;
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Código de animal");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Digite qual o código de animal:");
        codAnimal = int.Parse(Console.ReadLine());

        switch (codAnimal)
        {
            case 1: 
                Console.WriteLine($"Código {codAnimal}: Produto; Cavalo");
                break;
            case 2: 
                Console.WriteLine($"Código {codAnimal}: Produto; Leão");
                break;

            case 3:
                Console.WriteLine($"Código {codAnimal}: Produto; Onça");
                break;

            case 4: 
                Console.WriteLine($"Código {codAnimal}: Produto; Tigre");
                break;

            default: 
                Console.Write("Código Invalido!!!");
                break;
        }
    
    }
}