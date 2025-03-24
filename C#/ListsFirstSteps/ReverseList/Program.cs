List<string> words = new List<string> { "apple", "banana", "cherry" };
void RevereseList(List<string> listwords)
{
    listwords.Reverse();
    Console.WriteLine(string.Join(" ", words));
}
RevereseList(words);
