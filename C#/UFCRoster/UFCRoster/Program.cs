List<string> fightersNames = Console.ReadLine().Split(" ").ToList();
string input = Console.ReadLine();



while (input != "end")
{
    string[] commands = input.Split().ToArray();
    string command = commands[0];
    if (command == "Add")
    {
        string name = commands[1];
        fightersNames.Add(name);
    }
    else if (command == "Remove")
    {
        string name = commands[1];
        fightersNames.RemoveAll(b => b == name);
    }
    else if (command == "Promote")
    {
        string name = commands[1];
        if (fightersNames.Contains(name))
        {
            fightersNames.Remove(name);
            fightersNames.Insert(0, name);  
        }
        else
        {
            Console.WriteLine("Fighter not found.");
        }
       
    }
    else if (command == "Sort")
    {
        string name = commands[1];
        if (name == "desc")
        {
            fightersNames = fightersNames.OrderByDescending(n => n).ToList();
        }
        else if (name == "asc")
        {
            fightersNames = fightersNames.OrderBy(n => n).ToList();
        }
    }
    else if (command == "Search")
    {
        string keyword = commands[1];
        List<string> allFighterNames = fightersNames.Where(b => b.Contains(keyword)).ToList();
        if (allFighterNames.Count == 0)
        {
            Console.WriteLine("Fighter not found!");
        }
        else
        {
            Console.WriteLine(String.Join(", ", allFighterNames));
        }
    }
    else if (command == "Count")
    {
        Console.WriteLine(fightersNames.Count);
    }
    else if (command == "Insert")
    {
        string item = commands[1];
        int index = int.Parse(commands[2]);
        fightersNames.Insert(index, item);
    }
    else if (command == "Replace")
    {
        string oldFigter = commands[1];
        string newFighter = commands[2];

        if (fightersNames.Contains(oldFigter))
        {
            for (int i = 0; i < fightersNames.Count; i++)
            {
                if (fightersNames[i] == oldFigter)
                {
                    fightersNames[i] = newFighter;
                }
            }
        }
        else
        {
            Console.WriteLine("Fighter not found");
        }
    
    }
    else if(command == "Highlight")
    {
        Random random = new Random();
        int randomIndex = random.Next(0, fightersNames.Count);
        

        string hgFighter = fightersNames[randomIndex];

        Console.WriteLine($"Highlited fighter - {hgFighter}");


    }
    Console.WriteLine(String.Join(", ", fightersNames));
    input = Console.ReadLine();
}