double media;
int idade, somaIdade = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Qual a idade do {i}° aluno?: ");
    idade = int.Parse(Console.ReadLine());

    somaIdade = somaIdade + idade;
    
}
media = (double)somaIdade / 10;
Console.Write($"A media de idade da turma é: {media:f2}");
