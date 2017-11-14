using System.Web.Mvc;

namespace SantaTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Santas()
        {
            var santas = DAL.MockData.getMockSantas();
            return View(santas);
        }

        public ActionResult Locations()
        {
            var locations = DAL.MockData.getMockLocations();
            return View(locations);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Help";

            return View();
        }
    }
}