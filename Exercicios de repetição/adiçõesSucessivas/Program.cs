//Programa para realizar multiplicações através de adições sucessivas;
int x, y, resul;

Console.Write("informe o valor de X: ");
x = int.Parse(Console.ReadLine());
Console.Write("informe o valor de Y: ");
y = int.Parse(Console.ReadLine());

resul = 0;
for(int i = 1; i <= y; i++)
{
    resul = resul + x;
    
}
Console.Write($"O resultado da multiplicação entre {x} e {y} é: {resul}");