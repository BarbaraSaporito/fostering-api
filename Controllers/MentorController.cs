using Microsoft.AspNetCore.Mvc;

namespace FosteringAPI.Controllers
{
    public class MentorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
