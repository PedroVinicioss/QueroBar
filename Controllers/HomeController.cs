using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroBar.Models;
using QueroBar.Models.Data;
using System.Diagnostics;

namespace QueroBar.Controllers
{
    public class HomeController : Controller
    {

        private DatabaseContext _dbContext;
        public HomeController(DatabaseContext db)
        {
            _dbContext = db;
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