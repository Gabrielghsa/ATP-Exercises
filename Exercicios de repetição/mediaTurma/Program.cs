int n = 10, soma = 0, idade;
double media;

for(int i = 1; i <= n; i++)
{
    Console.Write($"Qual a idade do {i} aluno?: ");
    idade = int.Parse(Console.ReadLine());

    soma = soma + idade;

}
media = (double)soma / n;
Console.Write($"A média de idade da turma é: {media:f2}");