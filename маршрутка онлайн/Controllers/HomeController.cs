﻿using Microsoft.AspNetCore.Mvc;
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
            card_index card_Index = new card_index("Такси", "Lorem ipsum dolor sit amet", "Lorem ipsum dolor sit amet", "Lorem ipsum dolor sit amet", "~/img/такси_карт.png");

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