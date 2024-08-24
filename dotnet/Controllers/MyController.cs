using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
