int num, contPar = 0, contImpar = 0;

while (contImpar < 5 && contPar < 5)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0) {
        contPar = contPar + 1;
    }
    else{
        contImpar = contImpar + 1;
    }
    Console.WriteLine($"Pares: {contPar}");
    Console.WriteLine($"Ímpares: {contImpar}");
}

