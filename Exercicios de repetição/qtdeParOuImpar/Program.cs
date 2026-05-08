int num, qtdPar = 0, qtdImpar = 0;


while (qtdImpar < 5 && qtdPar < 5)
{

    Console.Write("Digite um número inteiro positivo: ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        qtdPar = qtdPar + 1;
    }
    else
    {
        qtdImpar = qtdImpar + 1;
    }
    Console.WriteLine($"Pares: {qtdPar}");
    Console.WriteLine($"ímpares: {qtdImpar}");


}