int n, idade, somaIdaBr = 0, qtdeItaliano = 0, qtdeUzbek = 0, somaIdaItal = 0; 
string pais;
double mediaIdades;
Console.Write("Informe um número positivo: ");
n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Qual a idade da {i}° pessoas");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine($"Qual a nacionalidade da {i}° pessoas");
    pais = Console.ReadLine().ToLower().Trim();

    if(pais == "brasileiro")
    {
        somaIdaBr += idade;
    }
    if(pais == "italiano")
    {
        somaIdaItal = somaIdaItal + idade;
        qtdeItaliano++;
           
    }
    if (pais == "uzbequistao")
    {
        qtdeUzbek = qtdeUzbek + 1;
    }

    
}
if(qtdeItaliano > 0)
{
    mediaIdades = somaIdaItal / qtdeItaliano;
}else
{
    mediaIdades = 0;
}
mediaIdades = (double)somaIdaItal / qtdeItaliano;
Console.WriteLine($"A soma de idades dos brasileiros é: {somaIdaBr}");
Console.WriteLine($"A média de idade dos italianos é: {mediaIdades}");
Console.WriteLine($"A quantidade de pessoas que nasceram em Uzbequistão é: {qtdeUzbek}");
