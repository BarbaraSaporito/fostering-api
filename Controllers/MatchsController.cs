using Microsoft.AspNetCore.Mvc;

namespace FosteringAPI.Controllers
{
    public class MatchsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
