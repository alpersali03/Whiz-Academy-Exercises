string[] players = new string[10];
string turningNumber = players[3];
Stack<string> stack = new Stack<string>();

for (int i = 0; i < turningNumber.Length; i++)
{
    stack.Push(players[i]);
    stack.Pop();
    if (stack.Count == 1)
    {
        string winningPlayer = stack.Peek();
        Console.WriteLine(winningPlayer);
    }
    
}