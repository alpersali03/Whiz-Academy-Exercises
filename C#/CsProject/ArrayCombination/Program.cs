int[]  Combination(int[] a, int[] b)
{
    int[] combined = a.Union(b).ToArray();


    return combined;
}
int[] array1 = { 1, 5, 7 };
int[] array2 = { 15, 19 };
int[] combinedArray = Combination(array1, array2);
Console.WriteLine(string.Join(" ", combinedArray));

