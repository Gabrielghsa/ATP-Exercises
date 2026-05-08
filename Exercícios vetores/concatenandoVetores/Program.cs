//Juntando dois vetores
//Utilizando método Concat 
int[] v1 = {1, 2, 3, 4, 5};
int[] v2 = {6, 7, 8, 9, 10};
int[] v3 = v1.Concat(v2).ToArray();
Console.Write(string.Join(", ", v3));

//Utilizando repetições
int[] nums1 = {11, 12, 13, 14, 15};
int[] nums2 = {16, 17, 18, 19, 20};
int[] resultado = new int[10];

for(int i = 0; i < nums1.Length; i++)
{
    resultado[i] = nums1[i];
}

for(int i = 0; i < nums2.Length; i++)
{
    resultado[nums1.Length + i] = nums2[i];
}
Console.Write(", ");
Console.Write(string.Join(", ", resultado));



