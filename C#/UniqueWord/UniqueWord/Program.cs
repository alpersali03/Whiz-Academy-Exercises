Dictionary<char, int> charCounts = new Dictionary<char, int>();
string symbols = Console.ReadLine();
for (int i = 0; i < symbols.Length; i++)
{
    char currentChar = symbols[i];
    if (charCounts.ContainsKey(currentChar))
    {
        
        charCounts[currentChar]++;
    }
    else
    {
        
        charCounts[currentChar] = 1;
    }

}
int misFound = charCounts.Values.Where(x => x > 1).FirstOrDefault(); 
if(misFound == 0)
{
    Console.WriteLine("The symbols are unique");
}
else if (misFound > 1)
{
    Console.WriteLine("The symbols are not unique");
}