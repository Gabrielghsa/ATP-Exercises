using System; 
class Program
{

    static bool validar(int n, int i, int j)
    {
        //Posso fazer assim
        /*int index;
        bool validado = false;
        
             if(n >= i && n <= j)
            {
                validado = true;

            } */
        //Ou fazer direto assim
        return n >= i && n <= j;


    }
    static void Main(){
        int n, i, j;
        Console.Write("Informe o valor de n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de i: ");
        i = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de j: ");
        j = int.Parse(Console.ReadLine());

        bool estaValidado = validar(n, i, j);
        Console.Write($"{estaValidado}");
    }
}