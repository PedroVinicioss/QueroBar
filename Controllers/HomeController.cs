using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.ViewModels;
using System.Diagnostics;

namespace QueroBar.Controllers
{
    public class HomeController : Controller
    {

        private DatabaseContext db;
        public HomeController(DatabaseContext _dbContext)
        {
            db = _dbContext;
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