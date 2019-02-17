using System.Web.Mvc;


namespace Whose_Turn_Is_It_Anyway.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This software is for taking turns";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult SharedTask()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}