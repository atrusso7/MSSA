using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Mar_movie_1
{
    class Movie
    {
        private string _title, _director, _rating;
        private string[] _ratings = { "G", "PG", "PG-13", "R" };
        public string title
        {
            get { return _title; }
            set { this._title = string.IsNullOrEmpty(value) ? throw new Exception("Title cannot be blank") : value; }
        }
        public string director
        {
            get { return _director; }
            set { this._director = string.IsNullOrEmpty(value) ? throw new Exception("Director cannot be blank") : value; }
        }
        public string rating
        {
            get { return _rating; }
            set { this._rating = !_ratings.Contains(value) ? throw new Exception("Rating must be: G, PG, PG-13, or R") : value; }
        }
        public void ShowMovie()
        {
            Console.WriteLine(title + director + rating);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Movie StarWars = new Movie()
            {
                title = "Star Wars",
                director = "George Lucas",
                rating = "PG-12"
            };
            StarWars.ShowMovie();
        }
    }
}