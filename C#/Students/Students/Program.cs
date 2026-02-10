Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
string command = Console.ReadLine();

while (command != "stop")
{
    string name = Console.ReadLine();
    List<int>notes = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
    students[name] = notes;
    command = Console.ReadLine();
}
foreach (var student in students)
{
    
}