int n, soma = 0, idade;
double media = 0;
Console.Write("Quantos alunos a turma possui?: ");
n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.Write($"Qual a idade do {i} aluno?: ");
    idade = int.Parse(Console.ReadLine());

    soma = soma + idade;

}
media = (double)soma / n;
Console.Write($"A média de idade da turma é: {media:f2}");