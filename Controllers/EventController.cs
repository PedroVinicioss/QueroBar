using Microsoft.AspNetCore.Mvc;
using QueroBar.Models.Data;
using QueroBar.Models.Entities;
using QueroBar.Util;

namespace QueroBar.Controllers
{
    public class EventController : Controller
    {
        private DatabaseContext db;
        public EventController(DatabaseContext _dbContext)
        {
            db = _dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Events events)
        {
            if(ModelState.IsValid)
            {
                //verificar como pegar usuario logado
                User user = new User();
                Pub pub = db.Pubs.FirstOrDefault(p => p.User_Id == user.Id);

                if(user != null)
                {
                    events.Pub_Id = pub.Id;
                    events.Pub = pub;

                    foreach(Pictures pictures in pub.Pictures)
                    {
                        var path = Functions.WriteFile(pictures.File, user.Id);

                        var fileName = Path.GetFileName(path);
                        var name = "images/" + user.Id + "/" + fileName;
                        pictures.Path = name;
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
                ModelState.AddModelError("Error", "Todos os campos são obrigatórios.");
            }
            return View();
        }
    }
}
