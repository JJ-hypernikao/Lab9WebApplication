using Lab9WebApplication.Models;
using Microsoft.AspNetCore.Authorization; // Needed for [Authorize]
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lab9WebApplication.Models;

namespace YourAppName.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // This action is accessible by ANYONE
        public IActionResult Index()
        {
            return View();
        }

        // *** ADD THE [Authorize] ATTRIBUTE HERE ***
        [Authorize]
        public IActionResult Privacy()
        {
            // Only logged-in users can reach this code
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}