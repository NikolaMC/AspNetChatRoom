using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreChatRoom.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(string username)
        {
            return View("Index", username);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
