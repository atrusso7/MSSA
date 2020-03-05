using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _4Feb_web_app.Models;

namespace _4Feb_web_app.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
    }
}
