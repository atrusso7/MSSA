using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _9Feb_working_with_visual_studio.Models;

namespace _9Feb_working_with_visual_studio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products.Where(p => p.Price < 50));
    }
}
