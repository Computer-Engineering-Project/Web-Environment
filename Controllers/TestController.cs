using Microsoft.AspNetCore.Mvc;

namespace DATN.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
