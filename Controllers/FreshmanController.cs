using Microsoft.AspNetCore.Mvc;

namespace FosteringAPI.Controllers
{
    public class FreshmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
