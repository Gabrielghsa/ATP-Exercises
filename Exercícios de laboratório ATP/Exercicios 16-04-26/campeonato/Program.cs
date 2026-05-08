int x, ponto = 0;
double aprov;
char resultado; 
Console.Write("Qual a quantidade de partidas a equipe realizou no campeonato?: ");
x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    Console.Write($"Informe o resultado da {i}° partida: ");
    resultado = char.Parse(Console.ReadLine());

    if(resultado == 'V')
    {
        ponto = ponto + 3;
    } else if (resultado == 'E')
    {
        ponto = ponto + 1;
    }
}
aprov = (double)ponto / (x * 3);

if (aprov <= 0.5)
{
    Console.Write("O pontuação baixa");
} else if(aprov <= 75)
{
    Console.Write("O pontuação foi boa");
} else
{
    Console.Write("O pontuação foi alta");
}
