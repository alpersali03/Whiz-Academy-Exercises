int[] numbers = { 1, 2, 3, 4, 5, 6 };
int max = 0;

for (int i = 0; i <= numbers.Length - 1; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine(max);