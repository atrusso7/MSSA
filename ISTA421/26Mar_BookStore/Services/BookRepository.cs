using System.Linq;
using System.Collections.Generic;
using _26Mar_BookStore.Controllers;
using _26Mar_BookStore.Models;

namespace _26Mar_BookStore.Services
{
    public class BookRepository : IRepository<Book>
    {
        List<Book> BookList;
        public BookRepository()
        {
            BookList = new List<Book>()
            {
                new Book()
                {
                Author = "Ernest Hemingway",
                BookID = 1,
                Title = "The Old Man and the Sea",
                Description = "The Old Man and the Sea tells the story of a battle between an aging, experienced fisherman, Santiago, and a large marlin. The story opens with Santiago having gone 84 days without catching a fish, and now being seen as 'salao', the worst form of unluckiness.",
                PublishDate = 1952,
                Price = 15.00,
                Image = "theoldman.jpg"
                },
                new Book()
                {
                Author = "John Steinbeck",
                BookID = 2,
                Title = "East of Eden",
                Description = "East of Eden is a novel by Nobel Prize winner John Steinbeck, published in September 1952. Often described as Steinbeck's most ambitious novel, East of Eden brings to life the intricate details of two families, the Trasks and the Hamiltons, and their interwoven stories.",
                PublishDate = 1952,
                Price = 12.00,
                Image = "eastofeden.jpg"
                },
                new Book()
                {
                Author = "Frank Herbert",
                BookID = 3,
                Title = "Dune",
                Description = "A 1965 science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966, and it won the inaugural Nebula Award for Best Novel.",
                PublishDate = 1965,
                Price = 15.00,
                Image = "dune.jpg"
                },
            };
        }
        public bool Add(Book item)
            {
                throw new System.NotImplementedException();
            }

            public bool Edit(Book item)
            {
                throw new System.NotImplementedException();
            }

            public Book Get(int id)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<Book> GetAll()
            {
                return BookList;
            }

            public bool Remove(Book item)
            {
                throw new System.NotImplementedException();
            }
        }
    }