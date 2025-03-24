List<int> numbers = new List<int>() { 5, 3, 5, 7, 5, 9 };
int target = 5;
int CountOccurrence(List<int> mynumbers, int target)
{
    return mynumbers.Count(n => n == target);
}
int count = CountOccurrence(numbers, target);
Console.WriteLine("Number " + target + " appears: " + count + " times.");