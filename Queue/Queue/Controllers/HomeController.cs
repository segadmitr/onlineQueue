using Microsoft.AspNetCore.Mvc;

namespace QueueApp.Service.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}