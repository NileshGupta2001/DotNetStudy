using Microsoft.AspNetCore.Mvc;

namespace WebAPISecurity.Controllers
{
    public class IPLPlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
