using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
using System.Runtime.Intrinsics.X86;

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
            user.name = newuser.name;
            user.email = newuser.email;
            user.password = newuser.password;
            user.status = (User.UserStatus)1;
            user.phone = newuser.phone;
            user.membership_id = 1;
            user.creationDate = DateTime.Now;

            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(User newuser)
        {
            User user = new User();
            user.name = newuser.name;  
            user.email = newuser.email;   
            user.password = newuser.password;
            return View();
        }
    }
}
