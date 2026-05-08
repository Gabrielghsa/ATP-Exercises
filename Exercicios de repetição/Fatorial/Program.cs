//Calculo de fatorial;
int fat, num;
Console.Write("Informe um número parra calcular sua fatorial: ");
num = int.Parse(Console.ReadLine());
fat = 1;

for(int i = 1; i <= num; i++)
{
    fat = fat * i;
}
Console.Write($"A fatorial de {num} é: {fat}");
