


//static int[] arrayReverse(int[] array)
//{

//}
Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int j = n-1;j >= 0; j--)
{
    Console.Write(arr[j]);
}