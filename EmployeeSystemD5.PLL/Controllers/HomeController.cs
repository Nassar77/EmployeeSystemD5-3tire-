using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystemD5.PLL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
