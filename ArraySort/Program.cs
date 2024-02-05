Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int temp;

for (int i = 0;i < arr.Length - 1; i++)
{
    for (int j = i+1;j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            // Swap
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}