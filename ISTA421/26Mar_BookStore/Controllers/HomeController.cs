using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _26Mar_BookStore.Models;
using _26Mar_BookStore.Services;

namespace _26Mar_BookStore.Controllers
{
    public class HomeController : Controller
    {
        List<Book> _book;
        IRepository<Book> _repo;
        IRepository<Carousel> _carousel;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _repo = new BookRepository();
            _book = new List<Book>();
            _carousel = new CarouselRepository();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_carousel.GetAll());
        }
        public IActionResult Books()
        {
            // var BookList = new List<Book>();
            // BookList.Add(new Book()
            // {
            //     Author = "Ernest Hemingway", 
            //     BookID = 1,
            //     Title = "The Old Man and the Sea", 
            //     Description = "The Old Man and the Sea tells the story of a battle between an aging, experienced fisherman, Santiago, and a large marlin. The story opens with Santiago having gone 84 days without catching a fish, and now being seen as 'salao', the worst form of unluckiness.",
            //     PublishDate = 1952,
            //     Price = 15.00,
            //     Image = "theoldman.jpg"
            // });
            // BookList.Add(new Book()
            // {
            //     Author = "John Steinbeck", 
            //     BookID = 2,
            //     Title = "East of Eden", 
            //     Description = "East of Eden is a novel by Nobel Prize winner John Steinbeck, published in September 1952. Often described as Steinbeck's most ambitious novel, East of Eden brings to life the intricate details of two families, the Trasks and the Hamiltons, and their interwoven stories.",
            //     PublishDate = 1952,
            //     Price = 12.00,
            //     Image = "eastofeden.jpg"
            // });
            return View(_repo.GetAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
