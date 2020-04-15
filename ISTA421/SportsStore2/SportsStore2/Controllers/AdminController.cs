using Microsoft.AspNetCore.Mvc;
using SportsStore2.Models;

namespace SportsStore2.Controllers
{
    public class AdminController : Controller {
        private IProductRepository repository;
        public AdminController(IProductRepository repo) {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);

        public IActionResult Delete()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Edit()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Create()
        {
            throw new System.NotImplementedException();
        }
    }
}