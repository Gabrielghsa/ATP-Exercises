int num, contPar = 0, contImpar = 0, qtdeN, i = 1;

Console.Write("Quando números serão lidos?: ");
qtdeN = int.Parse(Console.ReadLine());

while(i <= qtdeN)
{
    Console.Write($"Digite o {i}° número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        contPar = contPar + 1;
    }else
    {
        contImpar = contImpar + 1;
    }
    i++;
}
Console.WriteLine($"A quantidade de números pares é: {contPar}");
Console.Write($"A quantidade de números ímpares é: {contImpar}");