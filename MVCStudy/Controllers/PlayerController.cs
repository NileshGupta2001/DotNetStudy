using Microsoft.AspNetCore.Mvc;
using MVCStudy.Models;

namespace MVCStudy.Controllers
{
    public class PlayerController : Controller
    {
        public ApplicationDBContext dbContext;
        public IActionResult Index()
        {

            List<IPLPlayer> lstPlayer = dbContext.iplPlayer.ToList();
            return View(lstPlayer);
        }

        public PlayerController(ApplicationDBContext applicationDB
            )
        {
            dbContext=applicationDB;
        }

        [HttpPost]
        public IActionResult Create(IPLPlayer iPLPlayer)
        {


            dbContext.iplPlayer.Add(iPLPlayer);
            dbContext.SaveChanges();
            
            return RedirectToAction("Index","Player");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int ID)
        {
           var player= dbContext.iplPlayer.FirstOrDefault(x=>x.ID==ID);
            if(player!=null)
            {
                return View(player);
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Edit(IPLPlayer iPLPlayer)
        {

            dbContext.iplPlayer.Update(iPLPlayer);
            //dbContext.iplPlayer.Add(iPLPlayer);
            dbContext.SaveChanges();

            return RedirectToAction("Index", "Player");
        }

        [HttpPost]
        public IActionResult Delete(int ID)
        {
            var player = dbContext.iplPlayer.FirstOrDefault(x => x.ID == ID);

            if (player != null)
            {
                dbContext.iplPlayer.Remove(player);
                dbContext.SaveChanges();
                return RedirectToAction("Index", "Player");
            }

            return RedirectToAction("Index", "Player");
        }

    }
}
