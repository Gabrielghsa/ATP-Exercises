string s;
int contLetras;
int[] qtdLetras = new int[26];

Console.Write("Digite uma palavra: (Apenas letras minúsculas) ");
s = Console.ReadLine() ?? "";
s = s.ToLower();

for(int i = 0; i < s.Length; i++)
{
    char c = s[i];

    if(c >= 'a' && c <= 'z')
    {
        int indice = c - 'a';
        qtdLetras[indice]++;
    }
}

for(int i = 0; i < 26; i++)
{
    if(qtdLetras[i] > 0)
    {
        char letra = (char)('a' + i);
        Console.WriteLine($"A letra {letra} aparece {qtdLetras[i]} vezes");
    }
}
//For para mostrar todas as letras do alfabeto
for(char letra = 'a'; letra <= 'z'; letra++)
{
    Console.Write($"{letra}, ");
}

Console.WriteLine();
Console.Write($"{string.Join(", ", qtdLetras)}");

