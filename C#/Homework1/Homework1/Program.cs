//List<int> list1 = new List<int> { 3, 1, 4 };
//List<int> list2 = new List<int> { 6, 5, 2 };

//Combine(list1, list2);
//void Combine(List<int> first, List<int> second)
//{
//    first.AddRange(second);

//    Console.WriteLine(string.Join(" - ", first.OrderBy(x => x)));
//}

//List<int> numbers = new List<int> { 10, 20, 5, 30, 15 };
//int threshold = 15;

//List<int> biggerNumbers = RemoveLowerNumbers(numbers, threshold);


//Console.WriteLine();
//foreach (int number in biggerNumbers)
//{
//    Console.WriteLine(number);
//}
//List<int> RemoveLowerNumbers(List<int> numbers, int threshold)
//{

//    return numbers.Where(x => x >= threshold).ToList();
//}

//List<string> foods = Console.ReadLine().Split(' ').ToList();


//string command = Console.ReadLine();


//while (command != "end")
//{
//    string[] cmd = command.Split(' ').ToArray();

//    string func = cmd[0];

//    if (func == "Add")
//    {
//        string newProduct = cmd[1];
//        foods.Add(newProduct);
//    }
//    else if (func == "Remove")
//    {
//        string productToRemove = cmd[1];

//        // check is you should set foods = 
//        foods.RemoveAll(p => p == productToRemove);
//    }
//    else if (func == "Prioritize")
//    {
//        string product = cmd[1];

//        if (foods.Contains(product) == false)
//        {
//            Console.WriteLine("Item not found");
//        }
//        else
//        {
//            int indexOfProduct = foods.IndexOf(product);
//            foods.RemoveAt(indexOfProduct);

//            foods.Insert(0, product);
//        }
//    }
//    else if (func == "Sort")
//    {
//        string typeOfSorting = cmd[1];


//        // check it 
//        if (typeOfSorting == "asc")
//        {
//            foods = foods.Order().ToList();
//        }
//        else
//        {
//            foods = foods.OrderByDescending(x => x).ToList();
//        }
//    }

//    PrintList(foods);
//    command = Console.ReadLine();
//}


//void PrintList(List<string> list)
//{
//    Console.WriteLine(string.Join(' ', list));
//}

// TODO list
using System.Security.Cryptography;

List<string> tasks = Console.ReadLine().Split().ToList();
Console.WriteLine("Enter Add {task}:  - to add a task to the list");
Console.WriteLine("Enter Remove {task}:  - to remove a task from the list");
Console.WriteLine("Enter Complete {task}:  - to move the task to the end of the list");
Console.WriteLine("Enter Sort asc/desc - to sort the list in asc or desc order");


string option = Console.ReadLine();

while (option != "end")
{
    string[] cmd = option.Split(' ').ToArray();
    string command = cmd[0];
    string item = cmd[1];
    if (command == "Add")
    {
        string task = cmd[1];

        tasks.Add(task);

        Console.WriteLine($"Task added to the list - {task}");
    }
    else if (command == "Remove")
    {
        tasks.RemoveAll(t => t == cmd[1]);
    }
    else if (command == "Complete")
    {
        if (tasks.Contains(item) == true)
        {
            tasks.Remove(item);
            tasks.Add(item);
            Console.WriteLine("Task move to the end of the list");
        }
        else
        {
            Console.WriteLine("Task not found in the list");
        }

    }
    else if (command == "Sort")
    {
        string sortOrder = cmd[1];

        if (sortOrder == "asc")
        {
            tasks = tasks.Order().ToList();
            Console.WriteLine("Tasks dorted in ascending order");
        }
        else if (sortOrder == "desc")
        {
            tasks = tasks.OrderByDescending(t => t).ToList();
            Console.WriteLine("List sorted in descending order");
        }

    }
    Console.WriteLine(String.Join(" ", tasks));

    Console.WriteLine("Enter Add {task}:  - to add a task to the list");
    Console.WriteLine("Enter Remove {task}:  - to remove a task from the list");
    Console.WriteLine("Enter Complete {task}:  - to move the task to the end of the list");
    Console.WriteLine("Enter Sort asc/desc - to sort the list in asc or desc order");

    option = Console.ReadLine();
}
