using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroBar.Models;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
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
            User user = new User();
            user.name = "Pedro";
            user.email = "Pedro@gmail.com";
            user.password = "12345";
            user.type = (User.UserType)2;
            user.phone = "";
            user.creationDate = DateTime.Now;

            db.SaveChanges();
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