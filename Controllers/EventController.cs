using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
using QueroBar.Models.ViewModels;
using QueroBar.Util;
using System.Data.Entity;
using System.Security.Claims;

namespace QueroBar.Controllers
{
    public class EventController : Controller
    {
        private DatabaseContext db;
        public EventController(DatabaseContext _dbContext)
        {
            db = _dbContext;
        }
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.events = db.Events.FirstOrDefault(p => p.Id == id);

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEventViewModel createEvent)
        {
            if (ModelState.IsValid)
            {
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (userId != null)
                {
                    User user = db.Users.FirstOrDefault(x => x.Email == userId);

                    if (user != null)
                    {
                        Pub pub = db.Pubs.FirstOrDefault(p => p.User_Id == user.Id);
                        Events events = new Events
                        {
                            Pub_Id = pub.Id,
                            Name = createEvent.Name,
                            Description = createEvent.Description,
                            Capacity = createEvent.Capacity,
                            CreatedTime = DateTime.Now,
                            Genre_id = createEvent.Genre,
                            Category_id = createEvent.Category,
                            OpeningTime = createEvent.OpeningTime,
                            ClosingTime = createEvent.ClosingTime,
                            Price = createEvent.Price,
                        };

                        var path = "";
                        var name = "";

                        if (createEvent.ImageFile != null)
                        {
                            path = Functions.WriteFile(createEvent.ImageFile, user.Id);
                            var fileName = Path.GetFileName(path);
                            name = "images/" + user.Id + "/" + fileName;
                            events.Path = name;
                        }

                        db.Events.Add(events);
                        db.SaveChanges();
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Usuário não encontrado.");
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Usuário não encontrado 1.");
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Todos os campos são obrigatórios.");
            }

            return View();
        }

    }
}
