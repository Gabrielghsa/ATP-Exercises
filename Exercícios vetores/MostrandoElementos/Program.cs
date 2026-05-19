int[] nums = new int[] {5, 3, 12, 7, 10};
int soma = 0;
double media;

for(int i = 0; i < nums.Length; i++)
{
    soma += nums[i];
}
media = (double)soma / nums.Length; 

void exibePosicoes(int[] nums, double media)
{
    for(int i = 0; i < nums.Length; i++)
    {
        if(nums[i] > media)
        {
            Console.WriteLine($"O número {nums[i]} é maior que a média");
        }
    }
}
exibePosicoes(nums, media);