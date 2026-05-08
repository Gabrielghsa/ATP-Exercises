/*Faça um algoritmo em C# que determine se um dado número inteiro (informado pelo usuário) é positivo,
negativo ou nulo.*/

int posit, negat, nulo, num;

Console.Write("Informe um número: ");
num = int.Parse(Console.ReadLine());

if(num > 0)
{
    Console.Write("Positivo");
} else if(num < 0)
{
    Console.Write("Negativo");
}else 
    Console.Write("Nulo");