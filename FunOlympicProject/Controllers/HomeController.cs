using FunOlympicProject.Data;
using FunOlympicProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FunOlympicProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Privacy()
        {
            IEnumerable<Videos> videos = _context.Videos.ToList();
            return View(videos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}