using Microsoft.AspNetCore.Mvc;

namespace eMart.Presentaion.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() { 
            return View();
        }
    }
}
