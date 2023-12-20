using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
using QueroBar.Models.ViewModels;
using System.Data.Entity;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

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
            ClaimsPrincipal claimUser = HttpContext.User;

            if(claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");


            return View();
        }

        //Login/LogOut--------------------------------------------------------------------------------------------------------------------------

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Where(x => x.Email == login.Email && x.Password == login.Password).FirstOrDefault();
                if (user != null)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, login.Email),
                        new Claim("OtherProperties", user.Role)
                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties properties = new AuthenticationProperties() {
                        
                        AllowRefresh = true,
                        IsPersistent = login.KeepLoggedIn
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email ou senha Inválidos");
                }
            }
            else 
            { 
                ModelState.AddModelError("Error", "Todos os campos são obrigatórios."); 
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {   
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }


        //Registro --------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel newuser)
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
                    CreationDate = DateTime.Now,
                    Role = "Client"
                };

                db.Users.Add(user);
                db.SaveChanges();

                Pub pub = new Pub
                {
                    User_Id = user.Id,
                    CNPJ = "123456789"
                };

 
                db.Pubs.Add(pub);
                db.SaveChanges();
                // Após salvar o usuário, autentique-o automaticamente
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, newuser.Email),
                    new Claim("OtherProperties", user.Role)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = true 
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

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

        [HttpGet] 
        public ActionResult Perfil() {

            ClaimsPrincipal claimUser = HttpContext.User;

            if (!claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            else
            {
                var userClaims = User.Claims;

                var emailClaim = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                string email = emailClaim?.Value;

                var user = db.Users.Where(x => x.Email == email).FirstOrDefault();

                return View(user);
            }
        }
    }
}
