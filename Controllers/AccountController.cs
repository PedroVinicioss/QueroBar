using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
using QueroBar.Models.ViewModels;
using System.Data.Entity;
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

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var findUser = await db.Users.FirstOrDefaultAsync(p => p.Email == login.Email);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(User newuser)
        {
            User user = new User();
            user.Name = newuser.Name;
            user.Email = newuser.Email;
            user.Password = newuser.Password;
            user.Status = (User.UserStatus)1;
            user.Phone = newuser.Phone;
            user.Membership_Id = 1;
            user.CreationDate = DateTime.Now;

            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(User newuser)
        {
            User user = new User();
            user.Name = newuser.Name;
            user.Email = newuser.Email;
            user.Password = newuser.Password;
            return View();
        }
    }
}
