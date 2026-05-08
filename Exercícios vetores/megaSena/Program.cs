int qtdDezenas, acertos = 0, numApostado;
int[] aposta;
int[] sorteadas = new int[6];
Console.WriteLine("Aposta mínima 6 dezenas. Aposta máxima 15 dezenas");
do
{
Console.Write("Informe quantas dezenas você apostou: ");
qtdDezenas = int.Parse(Console.ReadLine());
}while(qtdDezenas < 6 || qtdDezenas > 15);
aposta = new int[qtdDezenas];


for (int i = 0; i < aposta.Length; i++)
{
    
    Console.Write($"Informe o {i+1}° número apostado: ");
    numApostado = int.Parse(Console.ReadLine());
    
    while(numApostado < 1 || numApostado > 60)
    {
        Console.Write($"Valor inválido! Digite novamente o {i+1}° número apostado (Apenas valores entre 1 a 60 são aceitos): ");
        numApostado = int.Parse(Console.ReadLine());
    }
    aposta[i] = numApostado;
}

Random rand = new Random();
for(int i = 0; i < sorteadas.Length; i++)
{
    sorteadas[i] = rand.Next(1, 61);
}

 for(int i = 0; i < aposta.Length; i++)
{
    bool encontrado = false;
    for(int j = 0; j < sorteadas.Length; j++)
    {
        if(aposta[i] == sorteadas[j])
        {
            acertos++;
            encontrado = true;
            break;
        }
    }
}
Console.WriteLine($"Os números apostados foram: {string.Join(", ", aposta)}");
Console.WriteLine($"Os números sortados foram: {string.Join(", ", sorteadas)}");
Console.Write($"A quantidade de acertos foi: {acertos}");
