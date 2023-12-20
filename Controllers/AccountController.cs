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
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel newuser)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    Name = newuser.Name,
                    Email = newuser.Email,
                    Password = newuser.Password,
                    Status = (User.UserStatus)1,
                    Phone = newuser.Phone,
                    Membership_Id = 2,
                    CreationDate = DateTime.Now
                };

                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Error", "Todos os campos são obrigatórios.");
            }
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
