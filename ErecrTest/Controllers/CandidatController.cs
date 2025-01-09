using Microsoft.AspNetCore.Mvc;

namespace ErecrTest.Controllers
{
    public class CandidatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
