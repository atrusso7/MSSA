using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34Mar_Indexer
{
    class Author
    {
        private string _authorName, _lifeSpan;
        private string[] _topBooks = new string[3];
        public string AuthorName { get => _authorName; set => _authorName = value; }
        public string LifeSpan { get => _lifeSpan; set => _lifeSpan = value; }
        public string this[int i] { get => _topBooks[i]; set => _topBooks[i] = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var hemingway = new Author()
            {
                AuthorName = "Ernest Hemingway",
                LifeSpan = "1899-1961",
                [0] = "The Old Man and the Sea",
                [1] = "Farewell to Arms", 
                [2] = "For Whom the Bell Tolls" 
            };
            Console.WriteLine($"Author: {hemingway.AuthorName}\nLifespan: {hemingway.LifeSpan}\nTop Books: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + (i + 1) + ". " + hemingway[i]);
            }
            Console.ReadLine();
        }
    }
}
