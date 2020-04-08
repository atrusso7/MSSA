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
            return View(_repo.GetAll());
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                Book item = new Book()
                {
                    BookID = _repo.GetAll().Max(x => x.BookID) + 1,
                    Title = Request.Form["Title"],
                    Author = Request.Form["Author"],
                    PublishDate = Convert.ToInt32(Request.Form["PublishDate"]),
                    Description = Request.Form["Description"],
                    Price = Convert.ToInt32(Request.Form["Price"]),
                    Image = Request.Form["Image"]
                };
                _repo.Add(item);
            }
            return RedirectToAction("Books");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
