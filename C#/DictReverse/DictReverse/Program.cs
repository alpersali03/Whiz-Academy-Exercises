Dictionary<char, int>word =  new Dictionary<char, int>(); 
string command = Console.ReadLine();

while (command != "end")
{
    string[] cmds = command.Split(" ");
    char wordKey = char.Parse(cmds[0]);
    int wordValue = int.Parse(cmds[1]);
    word[wordKey] = wordValue;
    command = Console.ReadLine();
}
Dictionary<int, char> reversedWord = new Dictionary<int, char>();
foreach (var item in word)
{
    char originalKey = item.Key;
    int originalValue = item.Value;

    
    reversedWord[originalValue] = originalKey;
}
Console.WriteLine("Reversed dictionary:");
foreach (var item in reversedWord)
{
    Console.WriteLine($"{item.Key} -> {item.Value:F2}");
}
Console.WriteLine("The program is finished");