using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPISecurity.Model;

namespace WebAPISecurity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IPLPlayersController : Controller
    {
        private ApplicationDBContext dBContext;
        public IPLPlayersController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [Authorize]
        [HttpGet]
        public IEnumerable<IPLPlayer> Get()
        {

            return dBContext.IPLPlayers.ToList();
        }
    }
}
