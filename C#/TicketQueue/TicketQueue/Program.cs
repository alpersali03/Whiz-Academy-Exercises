Queue<string>ticketQueue = new Queue<string> { };

ticketQueue.Enqueue("Alper");
ticketQueue.Enqueue("Ivan");
ticketQueue.Enqueue("Zdravko");
ticketQueue.Enqueue("Dimitar");
ticketQueue.Enqueue("Selim");
ticketQueue.Enqueue("Alpay");

foreach(string name in ticketQueue)
{
    Console.WriteLine($"Waiting on the queue - {name}");
}

while(ticketQueue.Count > 0)
{
    string servedPerson = ticketQueue.Dequeue();
    Console.WriteLine($"Served - {servedPerson}");
}