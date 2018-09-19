using System.Web.Mvc;

namespace KPMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
        public ActionResult SamplePage()
        {
            return View();
        }
    }
}
