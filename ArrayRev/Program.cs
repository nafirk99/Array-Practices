Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int[] reversedArray = new int[n];
for (int i = n;i < 0; i--)
{
    reversedArray[i] = arr[i];
}

foreach (int i in reversedArray)
{
    Console.WriteLine(i);
}


