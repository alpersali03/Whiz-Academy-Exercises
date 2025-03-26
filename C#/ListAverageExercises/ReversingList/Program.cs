using System.Collections.Generic;

List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
int positions = 2;
RotateList(numbers)
void RotateList(int[] list, int d, int n)
{
    d = d % n;
    int[] temp = new int[n];

    for(int i = 0; i < n; i++)
    {
        temp[i] = list[i];
    }
}
void PrintList(int[] list, int size)
{
    for(int i = 0; i < size; i++)
    {
        Console.Write(list[i]);
    }
    Console.WriteLine();
}
