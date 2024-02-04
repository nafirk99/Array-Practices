

Console.Write("Enter No Of Elements: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write("Enter Elements: ");
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}
Console.WriteLine("Sum: " + sum);