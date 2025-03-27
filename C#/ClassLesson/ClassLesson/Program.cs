using ClassLesson;
using System.Net;

Book book = new Book();
book.Author = "Erik von Markovik";
book.Title = "Mystery Method";
book.Year = 2006;

Console.WriteLine("Author: " + book.Author);
Console.WriteLine("Title: " + book.Title);
Console.WriteLine("Year: " + book.Year);