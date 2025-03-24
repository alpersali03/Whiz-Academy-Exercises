List<int> number = new List<int> {12, 42, 56, 17, 18, 20, 22,  98, 100 };
int SecondMax(List<int> numbers)
{
    numbers = numbers.OrderByDescending(number => number).ToList();
    return numbers[1];
}
int second = SecondMax(number);
Console.WriteLine(second);
