using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using маршрутка_онлайн.Models;

namespace маршрутка_онлайн.Controllers
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
            List< card_index> card_Index = new List<card_index>();
            sql sql = new sql();
            sql.vyvod(card_Index);

            return View(card_Index);
        }

        public IActionResult Taxi()
        {
            return View();
        }

        public IActionResult foreign_taxi()
        {
            return View();
        }
        
        public IActionResult cart()
        {
            return View();
        }

        public IActionResult attractions()
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