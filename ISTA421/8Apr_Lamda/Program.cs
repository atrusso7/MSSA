using System;
using System.Collections.Generic;


namespace _8Apr_Lamda
{
    public class BookRepository
    {
        List<Book> BookList;
        public BookRepository()
        {
            BookList = new List<Book>()
            {
                new Book()
                {
                ISBN = "9780099908401",
                Title = "The Old Man and the Sea",
                Price = 15,
                },
                new Book()
                {
                ISBN = "9788652118113",
                Title = "East of Eden",
                Price = 12,
                },
                new Book()
                {
                ISBN = "9788371502118",
                Title = "Dune",
                Price = 25,
                },
            };
        }
        public List<Book> GetAll()
        {
            return BookList;
        }
    }
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetAll();

            System.Console.WriteLine("[Books Less Than $20]");
            foreach (var book in books.FindAll(book => (book.Price < 20)))
            {
                System.Console.WriteLine($"Title: {book.Title}\nPrice: ${book.Price}.00\n");
            }
        }
    }
}
