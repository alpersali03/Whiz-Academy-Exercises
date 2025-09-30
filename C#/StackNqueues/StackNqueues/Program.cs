using Microsoft.VisualBasic;
using System.Collections;
using System.Net.Http.Headers;

//Queue q = new Queue();
//q.Enqueue(5);
//Console.WriteLine(q.Peek());

Stack<char> stack = new Stack<char>();
string myStrings = Console.ReadLine();

for (int i = 0; i < myStrings.Length; i++)
{
    char currentString = myStrings[i];
    stack.Push(currentString);
   
}
for (int i = 0;i < stack.Count; i++)
{
    Console.WriteLine(stack.Pop());
    i--;
}

