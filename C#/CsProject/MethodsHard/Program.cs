//bool CheckPalindrome(string palindrome)
//{
//    int lastIndex = palindrome.Length - 1;
//    for (int i = 0; i < palindrome.Length / 2; i++)
//    {
//        char left = palindrome[i];
//        char right = palindrome[lastIndex];
//        if (left != right)
//        {
//            return false;
//        }


//    }
//    return true;
//}
//string palindrome = Console.ReadLine();
//bool check = CheckPalindrome(palindrome);
//Console.WriteLine(check);


int Combination(int[] first, int[] second)
{
    int[] firstarr = new int[] { 1, 2, 3, 4 };
    int[] secondarr = new int[] { 11, 12, 13, 14 };
    int[] result = firstarr.Concat(secondarr).ToArray();
    return result;
}
int method = Combination()