Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.Write("Enter Value of X(Occurence): ");
int x = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0; i < n; i++)
{
    if(x == arr[i])
    {
        count++;
    }
}
Console.WriteLine($"{x} Occured {count} Times");
