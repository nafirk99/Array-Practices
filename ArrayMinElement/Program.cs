


Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int minimum = arr[0];
for (int i = 1; i < n; i++)
{
    if (arr[i] < minimum)
    {
        minimum = arr[i];
    }
}
Console.WriteLine($"Minimum is: {minimum}");