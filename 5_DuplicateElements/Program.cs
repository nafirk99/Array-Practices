

Console.Write("Enter No Of Elements: ");
int n = int.Parse(Console.ReadLine());
int[] arr= new int[n];
int count = 0;

Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

for (int i = 0;i < n; i++)
{
    for (int j = i+1; j < n; j++)
    {
       if (arr[i] == arr[j]) 
        { count++; }
    }
}
Console.WriteLine(count + " Duplicates");