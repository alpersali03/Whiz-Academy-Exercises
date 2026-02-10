Dictionary<char, int> text = new Dictionary<char, int>();
string word = Console.ReadLine();
for (int i = 0; i < word.Length; i++)
{
    char caracter = word[i];    

    if (text.ContainsKey(caracter))
    {
        text[caracter]++;
    }
    else
    {
        text[caracter] = 1;
    }
}
foreach (var entry in text)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}