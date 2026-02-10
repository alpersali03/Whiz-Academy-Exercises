using System.Globalization;

Dictionary<string, string> synonyms = new Dictionary<string, string>();
string command = Console.ReadLine();

while (command != "stop")
{
    string[] cmds = command.Split(" -> ");
    string word = cmds[0];
    string synonymword = cmds[1];
    synonyms[word] = synonymword;  
    command = Console.ReadLine();
}
string secondWord = Console.ReadLine();
if (synonyms.ContainsKey(secondWord))
{

    Console.WriteLine(synonyms[secondWord]);
}
else
{
    Console.WriteLine("The synonym doesn't exsist");
    Console.WriteLine(synonyms);
}