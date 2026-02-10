Dictionary<string, int> product = new Dictionary<string, int>();
string command = Console.ReadLine();

while (command != "end")
{
    string[] cmds = command.Split(" ");
    string productName = cmds[0];
    int quantity = int.Parse(cmds[1]);
    if (product.ContainsKey(productName))
    {
        product[productName] += quantity;

    }
    else
    {
        product[productName] = quantity;
    }
   
    command = Console.ReadLine();
    
    
}
foreach(var item in product)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
