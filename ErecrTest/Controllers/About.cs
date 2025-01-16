using Microsoft.AspNetCore.Mvc;

namespace ErecrTest.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
