//void PrintArrayElements(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        int current = arr[i];
//        Console.WriteLine(current);
//    }
//}
//int[] myArray = { 1, 2, 3, 4, 5 };
//PrintArrayElements(myArray);
//void PrintEvenNumbers(int N)
//{
//    for (int i = 1; i <= N; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//int evenNums = int.Parse(Console.ReadLine());
//PrintEvenNumbers(evenNums);

void ReverseArray(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Console.Write($" {arr[i]}");
    }
}
int[] reverse = {1, 2, 3, 4, 5, 6, 7, 8};
ReverseArray(reverse);