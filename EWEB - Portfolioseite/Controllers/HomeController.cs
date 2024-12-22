using System.Diagnostics;
using EWEB___Portfolioseite.Models;
using Microsoft.AspNetCore.Mvc;

namespace EWEB___Portfolioseite.Controllers
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
        public IActionResult Kontakt()
        {
            return View(new KontaktViewModel());
        }
        public IActionResult Projekte()
        {
            return View();
        }
        public IActionResult KontaktformularSend()
        {
            var viewmodel = new KontaktViewModel()
            {
                Name="ABC", 
                Text="DEF",
                KontaktformularText="GHI",
            };
            return View("Kontakt", viewmodel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
