Queue<(string Name, int Pages)> printerQueue = new Queue<(string, int)>();

// Add documents to the queue
printerQueue.Enqueue(("Документ1", 5));
printerQueue.Enqueue(("Документ2", 3));

// Process the printer queue
while (printerQueue.Count > 0)
{
    // Dequeue the next document
    var currentDocument = printerQueue.Dequeue();

    // Simulate printing the document
    Console.WriteLine($"Отпечатване на: {currentDocument.Name} ({currentDocument.Pages} страници)");
    Console.WriteLine($"Завършено: {currentDocument.Name}");
}