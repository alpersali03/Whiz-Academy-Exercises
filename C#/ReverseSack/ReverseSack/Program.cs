using System.Collections;
Stack<int> stack = new Stack<int>();
int[] numbers = new int[5];

for (int i = numbers.Length; i > 0; i--)
{
    stack.Push(i);
   
}
int [] numbers2 = new int[numbers.Length];
for (int i = 0;i < numbers2.Length; i++)
{
    numbers2[i] = stack.Pop();
    
}

Console.WriteLine("[" + string.Join(", ",  numbers2) + "]");