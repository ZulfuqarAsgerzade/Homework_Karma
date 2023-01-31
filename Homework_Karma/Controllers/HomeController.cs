using Homework_Karma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework_Karma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}