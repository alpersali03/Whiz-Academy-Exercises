    int[] ArrayRemovedDuplicates(int[] arr)
    {
        int[] unique = new int[arr.Length];

        int insertIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            // current 
            int currentElement = arr[i];

            if (unique.Contains(currentElement) == false)
            {
                unique[insertIndex] = currentElement;
                insertIndex++;
            }
        }
        return unique;
    }



int[] arrayNumbers = {1,1,1,1,1,1,2,3,4,5,6,6,6,6};
int[] noDublicates = ArrayRemovedDuplicates(arrayNumbers);

Console.WriteLine(string.Join('-', noDublicates));

//int[] EvenNumbers(int[] arr) => arr.Where(x => x % 2 == 0).ToArray();


//int[] arrayNumbers = Console.ReadLine()
//                                    .Split(" ")
//                                    .Select(int.Parse) //
//                                    .ToArray();


//int max = arrayNumbers.Max();
//int min = arrayNumbers.Min();
//Console.WriteLine(max);

//int[] noDublicates = ArrayRemovedDuplicates(arrayNumbers);

//Console.WriteLine(string.Join('-', noDublicates));


// IEnumerable 
//Array

//int[] a = { 1, 5, 7 };
//int[] b = { 15, 19 };


//int[] z = a.Union(b).ToArray();

//Console.WriteLine(string.Join(' ', z));


//string word = "radar";
//string reversedWord = word.Reverse().ToString();

//if (word == reversedWord)
//{

//}


