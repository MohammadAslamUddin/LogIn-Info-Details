using LogInInfoDetails.Manager;
using LogInInfoDetails.Models;
using System.Web.Mvc;

namespace LogInInfoDetails.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        private AppUserManager appUserManager;

        public LogInController()
        {
            appUserManager = new AppUserManager();
        }
        public ActionResult LogIn()
        {
            ViewBag.LogIn = appUserManager.LogIn();
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(AppUser user)
        {
            ViewBag.LogIn = appUserManager.LogIn();
            return View();
        }
    }
}