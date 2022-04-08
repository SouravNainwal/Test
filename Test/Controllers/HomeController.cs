using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Data()
        {
            ViewBag.name = "Sourav nainwal";
            ViewBag.Cit = "Delhi";

            ViewData["name"] = "hjdgsfjughksdhf";
            ViewData["phoneno"] = 8965445634;

            TempData["hgdsc"] = "shgjgs";
            TempData["list"] = new List<int>()
            {
                56,76,76,89
            };


            HttpContext.Session.SetString("Msg", "coder");
            ViewBag.res = HttpContext.Session.GetString("Msg");
            return View();
        }
        public IActionResult Index()
        {
            return View();
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
