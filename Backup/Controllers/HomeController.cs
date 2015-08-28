using System.Web.Mvc;

namespace HearMe.WebMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
