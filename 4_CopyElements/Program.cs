// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Enter No Of Elements: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int[] newarr = new int[n];

Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

for (int i = 0;i < n; i++)
{
    newarr[i] = arr[i];
}
Console.WriteLine("Copied Elements: ");
foreach (int i in newarr)
{
    Console.WriteLine(i);
}