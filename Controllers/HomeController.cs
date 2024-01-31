using System.Diagnostics;
using GitFun.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
        