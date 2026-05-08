int numAnimais, meses = 0, qtdeGatos = 0, caoVelho = 0, qtdeArara = 0;
double mediaAra;
string especie;


Console.Write("Qual a quantidade de animais?: ");
numAnimais = int.Parse(Console.ReadLine());

for(int i = 1; i <= numAnimais; i++)
{
    Console.WriteLine($"Qual a especie do {i}° animal?: ");
    especie = Console.ReadLine();
    Console.WriteLine($"Qual a idade em meses do {i}° animal?: ");
    meses = int.Parse(Console.ReadLine());

    if(especie == "Gatos")
    {
        qtdeGatos = qtdeGatos + 1;
    }
    if(especie == "Cachorro")
    {
        if(meses > caoVelho)
        {
            caoVelho = meses;
        }
    }
    if(especie == "Arara")
    {
        qtdeArara = qtdeArara + 1;
        meses += meses;
    }
}
if(qtdeArara > 0)
{
    mediaAra = (double)meses / qtdeArara;
}else 
    mediaAra = 0;
    
Console.WriteLine($"A quantidade de gatos é: {qtdeGatos}");
Console.WriteLine($"A idade do cão mais velho é: {caoVelho}");
Console.WriteLine($"A média de idade das araras é: {mediaAra}");
