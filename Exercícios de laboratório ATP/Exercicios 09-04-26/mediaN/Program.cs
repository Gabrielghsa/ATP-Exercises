int somaIdade = 0, nAlunos, i, idade;
double media; 

Console.Write("Quantos alunos a sala possui?: ");
nAlunos = int.Parse(Console.ReadLine());

for (i = 1; i <= nAlunos; i++)
{
    Console.Write($"Qual a idade do {i}° aluno?: ");
    idade = int.Parse(Console.ReadLine());

    somaIdade = somaIdade + idade;
}
media = (double)somaIdade / nAlunos;
Console.Write($"A média de idades da turma é: {media}");
