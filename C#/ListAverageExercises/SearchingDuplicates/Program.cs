List<int> numbers = new List<int>{ 1, 2, 3, 2, 4, 5, 3, 6, 7, 5 };
List<int> duplicateNumbers = new List<int>();

foreach(int number in numbers)
{
    if (duplicateNumbers.Contains(number) == false)
    {
        duplicateNumbers.Add(number);
    }
}
Console.WriteLine("duplicate Numbers");
PrintArray(duplicateNumbers.ToArray());
void PrintArray(int[] numArray)
{
    foreach(int num in numArray)
    {
        Console.WriteLine($"{num}");
    }
    Console.WriteLine();
}