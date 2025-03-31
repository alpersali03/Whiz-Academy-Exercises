using BookLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Book ebook = new Ebook("1984", "George Orwell");
        Book printedBook = new PrintedBook("The Great Gatsby", "F. Scott Fitzgerald", 3);

        ebook.Borrow();
        printedBook.Borrow();
        printedBook.Borrow();
        printedBook.Return();
    }
}