List<int> list1 = new List<int> { 3, 1, 4 };
List<int> list2 = new List<int> { 6, 5, 2 };

Combine(list1, list2);
void Combine(List<int> first, List<int> second)
{
    first.AddRange(second);

    Console.WriteLine(string.Join(" - ", first.OrderBy(x => x)));
}
