using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using маршрутка_онлайн.Models;
using маршрутка_онлайн.Models.sql;

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
            sql_index sql = new sql_index();
            sql.rider(card_Index);

            return View(card_Index);
        }

        public IActionResult Taxi()
        {
            List<card_taxi> card_ = new List<card_taxi>();
            sql_taxi sql = new sql_taxi("card_taxi");
            sql.rider(card_);
            return View(card_);
        }

        public IActionResult foreign_taxi()
        {
            List<card_taxi> card_ = new List<card_taxi>();
            sql_taxi sql = new sql_taxi("card_foreign_taxi");
            sql.rider(card_);
            return View(card_);
        }
        
        public IActionResult cart()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Message(message message)
        {
            sql_mes sql_Mes = new sql_mes();
            if (ModelState.IsValid)
            {
                await Task.Run(() => sql_Mes.add(message));
            }

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}