using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewWithModel.Models;

namespace PartialViewWithModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id = 101, Description = "Best Product", Name = "Securtiy solution", ImageUrl = "~/Images/IT-SECURITY.png", Price = 1200},
                new Product(){Id = 102, Description = "Best Product", Name = "infogaurd service solution", ImageUrl = "~/Images/service-5.jpg", Price = 1200},
                new Product(){Id = 103, Description = "Best Product", Name = "InfoGaurd best solution", ImageUrl = "~/Images/WEIGHING-10.png", Price = 1200}
            };
            return View(products);
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
