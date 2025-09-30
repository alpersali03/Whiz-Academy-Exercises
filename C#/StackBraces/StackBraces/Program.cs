Stack<char> stack = new Stack<char>();
string braces = Console.ReadLine();

if (braces == "(()())")
{
    stack.Push(braces);
    Console.WriteLine(true);
}
else if (braces == "(()")
{
    stack.Pop(braces);
    Console.WriteLine(false);
}