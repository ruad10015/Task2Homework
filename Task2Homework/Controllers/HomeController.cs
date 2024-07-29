using Microsoft.AspNetCore.Mvc;
namespace Task2Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
