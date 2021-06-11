using Microsoft.AspNetCore.Mvc;

namespace Razor
{
    public class HomeController : Controller
    
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}