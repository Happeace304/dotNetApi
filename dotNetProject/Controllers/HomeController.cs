using dotNetProject.DAL;
using System.Linq;
using System.Web.Mvc;

namespace dotNetProject.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Users.ToList());
        }
    }
}
