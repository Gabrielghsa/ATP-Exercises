string[] nomes = new string[3];
double[] notas = new double[3];
double[] frequencia = new double[3];
bool[] situacao = new bool[3];
int i;
for(i = 0; i < nomes.Length; i++)
{
    Console.Write($"Informe o nome do {i+1}° aluno: ");
    nomes[i] = Console.ReadLine();
    Console.Write($"Informe a nota do {i+1}° aluno: ");
    notas[i] = double.Parse(Console.ReadLine());
    Console.Write($"Informe a frequência do {i+1}° aluno: ");
    frequencia[i] = double.Parse(Console.ReadLine());
}

for(i = 0; i < situacao.Length; i++)
{
    if(notas[i] >= 60 && frequencia[i] >= 75)
    {
        situacao[i] = true;
    }else
    {
        situacao[i] = false;
    }
}

for(i = 0; i < nomes.Length; i++)
{
    if(situacao[i])
    {
        Console.WriteLine($"O aluno {nomes[i]} está aprovado e ocupa a posição {i+1}");
        
    }
}



