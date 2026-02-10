Dictionary<string, double> product = new Dictionary<string, double>();
string command = Console.ReadLine();

while(command != "end")
{
    string[] parts = command.Split(' ');
    string productName = parts[0];
    double price = double.Parse(parts[1]);
    product[productName] = price;
    command = Console.ReadLine();
}
foreach (var item in product)
{
    Console.WriteLine($"{item.Key} -> {item.Value:F2}");
}
Console.WriteLine("No more products");