using System;

List<string> books = Console.ReadLine().Split(" ").ToList();
string input = Console.ReadLine();

Random random = new Random();

while (input != "end")
{
    string[] commands = input.Split().ToArray();
    string command = commands[0];
    if (command == "Add")
    {
        string item = commands[1];
        books.Add(item);
    }
    else if (command == "Remove")
    {
        string item = commands[1];
        books.RemoveAll(b => b == item);
    }
    else if(command == "Read")
    {
        string item = commands[1];
        books.Remove(item);
        books.Add(item);
    }
    else if (command == "Sort")
    {
        string item = commands[1];
        if (item == "desc")
        {
            books = books.OrderByDescending(b => b).ToList();
        }
        else if (item == "asc")
        {
            books = books.OrderBy(b => b).ToList();
        }
    }
    else if (command == "Search")
    {
        string keyword = commands[1];
        List<string> foundedWords = books.Where(b => b.Contains(keyword)).ToList();
        if (foundedWords.Count == 0)
        {
            Console.WriteLine("Books not found!");
        }
        else
        {
            Console.WriteLine(String.Join(", ", foundedWords));
        }
    }
    else if (command == "Count")
    {
        Console.WriteLine(books.Count);
    }
    else if (command == "Insert")
    {
        string item = commands[1];
        books.Insert(0, item);
    }
    else if (command == "Replace")
    {
        string oldtitle = commands[1];
        string newtitle = commands[2];
        
        if (books.Contains(oldtitle))
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i] == oldtitle)
                {
                    books[i] = newtitle;
                }
            }
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }
    else if (command == "Recommend")
    {
        if (books.Count > 0)
        {
            int randomIndex = random.Next(books.Count);
            Console.WriteLine("Recommended book: " + books[randomIndex]);
        }
        else
        {
            Console.WriteLine("No books to recommend.");
        }
    }
    Console.WriteLine(String.Join(", ", books));
    input = Console.ReadLine();
}