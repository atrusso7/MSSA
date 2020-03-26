using System;
using Microsoft.AspNetCore.Mvc;

namespace _26Mar_BookStore.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int PublishDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}