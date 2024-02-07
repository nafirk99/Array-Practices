//Input: arr[] = { 1, 4, 20, 3, 10, 5 }, sum = 33
//Output: Sum found between indexes 2 and 4
//Explanation: Sum of elements between indices 2 and 4 is 20 + 3 + 10 = 33

//Input: arr[] = { 1, 4, 0, 0, 3, 10, 5 }, sum = 7
//Output: Sum found between indexes 1 and 4
//Explanation: Sum of elements between indices 1 and 4 is 4 + 0 + 0 + 3 = 7

//Input: arr[] = { 1, 4 }, sum = 0
//Output: No subarray found
//Explanation: There is no subarray with 0 sum

Console.Write("Enter Number Of Elements: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.Write("Enter Elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.Write("Enter Expected Sum: ");
int expectedSum = int.Parse(Console.ReadLine());
int currentSum;

for (int i = 0; i < n; i++)
{
    currentSum = arr[i];
    if (currentSum == expectedSum)
    {
        Console.WriteLine($"Sum found at: {i}");
        return;
    }
    else
    {
        for (int j = i + 1; j < n; j++)
        {
            currentSum += arr[j];
            if (currentSum == expectedSum)
            {
                Console.WriteLine($"Sum found between indexes {i} and {j}");
                return;
            }
        }
    }
}

Console.WriteLine("No subarray found with the expected sum.");
