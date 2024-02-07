//Input: { 0, 1, 2, 0, 1, 2}
//Output: { 0, 0, 1, 1, 2, 2}

//Input: { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
//Output: { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2}

Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int[] result = new int[arr.Length];
int zero = 0, one = 0, two = 0; 

for(int i = 0; i < n; i++)
{
    if (arr[i] == 0)
    {
        zero++;
    }
    if (arr[i] == 1)
    {
        one++;
    }
    if (arr[i] == 2)
    {
        two++;
    }
}
if (zero > 0)
{
    for (int i = 0; i < zero; i++)
    {
        result[i] = 0;
    }
}
if (one > 0)
{
    for (int i = zero; i < zero+one; i++)
    {
        result[i] = 1;
    }
}
if (two > 0)
{
    for (int i = zero + one; i < zero + one + two; i++)
    {
        result[i] = 2;
    }
}
Console.WriteLine($"{zero},{one},{two}");
foreach (var item in result)
{
    Console.Write(item);
}