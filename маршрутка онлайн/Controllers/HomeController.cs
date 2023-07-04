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
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
            List<card_taxi> card_ = new List<card_taxi>();
            sql_taxi sql = new sql_taxi(connectionString, "card_taxi");
            sql.rider(card_);
            return View(card_);
        }

        public IActionResult foreign_taxi()
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
            List<card_taxi> card_ = new List<card_taxi>();
            sql_taxi sql = new sql_taxi(connectionString, "card_foreign_taxi");
            sql.rider(card_);
            return View(card_);
        }
        
        public IActionResult cart()
        {
            List<cart> card_Index = new List<cart>();
            sql_cart sql = new sql_cart();
            sql.rider(card_Index);

            return View(card_Index);
        }

        [HttpGet]

        public IActionResult Administration()
        {
            card_index card_Index = new card_index();
            card_taxi card_Taxi = new card_taxi();
            message message = new message();

            Combomodel combomodel = new Combomodel(card_Index, card_Taxi, message);
            return View(combomodel);
        }


        [HttpGet]

        public IActionResult Message()
        {
            return View();
        }

        [HttpGet]

        public IActionResult avtor()
        {
            return View();
        }

        [HttpGet]

        public IActionResult in_taxi()
        {
            return View();
        }

        [HttpGet]

        public IActionResult up_taxi()
        {
            return View();
        }

        [HttpGet]

        public IActionResult del_taxi()
        {
            return View();
        }
        [HttpGet]

        public IActionResult in_foreign_taxi()
        {
            return View();
        }

        [HttpGet]

        public IActionResult up_foreign_taxi()
        {
            return View();
        }

        [HttpGet]

        public IActionResult del_foreign_taxi()
        {
            return View();
        }

        [HttpGet]

        public IActionResult in_main()
        {
            return View();
        }

        [HttpGet]

        public IActionResult up_main()
        {
            return View();
        }

        [HttpGet]

        public IActionResult del_main()
        {
            return View();
        }

        [HttpGet]

        public IActionResult in_cart()
        {
            return View();
        }

        [HttpGet]

        public IActionResult up_cart()
        {
            return View();
        }

        [HttpGet]

        public IActionResult del_cart()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Message(message message)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_mes sqlMes = new sql_mes(connectionString);

            if (ModelState.IsValid)
            {
                await sqlMes.Add(message);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]

        public async Task<IActionResult> avtor(admin ad)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_ad sqlad = new sql_ad(connectionString);
            List<admin> admins = new List<admin>();
            sqlad.rider(admins);

            if (ModelState.IsValid)
            {
                foreach (var item in admins) 
                { 
                    if(item.log==ad.log&&item.pass==ad.pass)
                        return RedirectToAction("Administration");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]


        public async Task<IActionResult> in_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_taxi");

            if (ModelState.IsValid)
            {
                await sqlMes.Add(taxi);
        }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> up_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_taxi");

            if (ModelState.IsValid)
            {
                await sqlMes.Update(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> del_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_taxi");

            if (!string.IsNullOrEmpty(taxi.zag))
            {
                await sqlMes.Delete(taxi);
            }

            return RedirectToAction("Administration");
        }
        public async Task<IActionResult> in_foreign_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_foreign_taxi");

            if (ModelState.IsValid)
            {
                await sqlMes.Add(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> up_foreign_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_foreign_taxi");

            if (ModelState.IsValid)
            {
                await sqlMes.Update(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> del_foreign_taxi(card_taxi taxi)
        {
            string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

            sql_taxi sqlMes = new sql_taxi(connectionString, "card_foreign_taxi");

            if (!string.IsNullOrEmpty(taxi.zag))
            {
                await sqlMes.Delete(taxi);
            }

            return RedirectToAction("Administration");
        }


        public async Task<IActionResult> in_main(card_index taxi)
        {
            sql_index sqlMes = new sql_index();

            if (ModelState.IsValid)
            {
                await sqlMes.Add(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> up_main(card_index taxi)
        {
            sql_index sqlMes = new sql_index();

            if (ModelState.IsValid)
            {
                await sqlMes.Update(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> del_main(card_index taxi)
        {
            sql_index sqlMes = new sql_index();

            if (!string.IsNullOrEmpty(taxi.zag))
            {
                await sqlMes.Delete(taxi);
            }

            return RedirectToAction("Administration");
        }

        public async Task<IActionResult> in_cart(cart taxi)
        {
            sql_cart sqlMes = new sql_cart();

            if (ModelState.IsValid)
            {
                await sqlMes.Add(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> up_cart(cart taxi)
        {
            sql_cart sqlMes = new sql_cart();

            if (ModelState.IsValid)
            {
                await sqlMes.Update(taxi);
            }

            return RedirectToAction("Administration");
        }

        [HttpPost]

        public async Task<IActionResult> del_cart(cart taxi)
        {
            sql_cart sqlMes = new sql_cart();

            if (!string.IsNullOrEmpty(taxi.name))
            {
                await sqlMes.Delete(taxi);
            }

            return RedirectToAction("Administration");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}