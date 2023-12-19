using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;

namespace QueroBar.Controllers
{
    public class AccountController : Controller
    {
        private DatabaseContext db;
        public AccountController(DatabaseContext _dbContext)
        {
            db = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User newuser)
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
    }
}
