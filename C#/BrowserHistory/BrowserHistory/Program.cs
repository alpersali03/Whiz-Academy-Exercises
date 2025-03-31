//Stack<string>websites = new Stack<string>();
//string command = Console.ReadLine();
//while(command != "2")
//{
//    // 1 githyb
//    // 1 facebook 
//    string[] cmd = command.Split(' ');
//    websites.Push(cmd[1]);

//    command = Console.ReadLine();
//}
//string lastWebsite = websites.Peek();
//Console.WriteLine(lastWebsite);


Stack<string> website = new Stack<string>();
string command = Console.ReadLine();

while (command != "2")
{
    string[] cmd = command.Split(" ");
    website.Push(cmd[1]);
    command = Console.ReadLine();
}
string lastWebsite = website.Peek();
Console.WriteLine(lastWebsite);