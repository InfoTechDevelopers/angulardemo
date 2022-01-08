using AngularJsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AngularJsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext context;

        public HomeController(
            ILogger<HomeController> logger, 
            AppDbContext context
            )
        {
            _logger = logger;
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Makes = new SelectList(await context.Makes?.ToListAsync(), "Id", "Name");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetModels(int id)
        {
            Thread.Sleep(5000);

            return Json(await context.Models.Where(p => p.MakeId == id).ToListAsync());
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