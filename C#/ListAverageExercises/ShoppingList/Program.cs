using System.Linq;

List<string> foods = Console.ReadLine().Split(' ').ToList();


string command = Console.ReadLine();


while (command != "end")
{
    string[] cmd = command.Split(' ').ToArray();

    string func = cmd[0];

    if (func == "Add")
    {
        string newProduct = cmd[1];
        foods.Add(newProduct);
    }
    else if (func == "Remove")
    {
        string productToRemove = cmd[1];

        // check is you should set foods = 
        foods.RemoveAll(p => p == productToRemove);
    }
    else if (func == "Prioritize")
    {
        string product = cmd[1];

        if (foods.Contains(product) == false)
        {
            Console.WriteLine("Item not found");
        }
        else
        {
            int indexOfProduct = foods.IndexOf(product);
            foods.RemoveAt(indexOfProduct);

            foods.Insert(0, product);
        }
    }
    else if (func == "Sort")
    {
        string typeOfSorting = cmd[1];


        // check it 
        if (typeOfSorting == "asc")
        {
            foods = foods.Order().ToList();
        }
        else
        {
            foods = foods.OrderByDescending(x => x).ToList();
        }
    }

    PrintList(foods);
    command = Console.ReadLine();
}


void PrintList(List<string> list)
{
    Console.WriteLine(string.Join(' ', list));
}