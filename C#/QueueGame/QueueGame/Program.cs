List<string>players = new List<string> { "Ана", "Боби", "Катя", "Дани" };
int rotation = 3;
Queue<string> queue = new Queue<string>(players);

while (queue.Count > 1)
{
    for (int i = 1; i < rotation - 2 ; i++)
    {
        string player = queue.Dequeue();
        queue.Enqueue(player);
    }
    string removedPlayer = queue.Dequeue();
}
string winner = queue.Dequeue();
Console.WriteLine(winner);