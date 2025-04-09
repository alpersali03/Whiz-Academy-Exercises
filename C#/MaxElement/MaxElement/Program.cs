//Stack<int> stack = new Stack<int>();
//int n = int.Parse(Console.ReadLine());

//int maxNum = -1000;

//for (int i = 0; i < n; i++)
//{
//    int number = int.Parse(Console.ReadLine());
//    stack.Push(number);
     
//}


//for (int i = 0; i < n; i++)
//{ 
//    int currentNumber  = stack.Pop();
//    if (currentNumber > maxNum)
//    {
//        maxNum = currentNumber;
//    }
//}
//Console.WriteLine(maxNum);


Stack<int> stack = new Stack<int>();    
int n  = int.Parse(Console.ReadLine());

int maxNum = -1000;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    stack.Push(number);
}

for (int i = 0;i < n; i++)
{
    int currentNumber = stack.Pop();
    if (currentNumber > maxNum)
    {
        maxNum = currentNumber; 
    }
}
Console.WriteLine(maxNum);