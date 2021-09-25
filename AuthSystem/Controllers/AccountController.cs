using AuthSystem.Manager;
using AuthSystem.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthSystem.Controllers
{
    public class AccountController : Controller
    {
        private AccountManager accountManager;

        public AccountController()
        {
            accountManager = new AccountManager();
        }
        // GET: Account
        public ActionResult LogIn()
        {
            ViewBag.list = accountManager.lists();
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogIn(Login login)
        {
            ViewBag.list = accountManager.lists();
            if (IsValid(login))
            {
                FormsAuthentication.SetAuthCookie(login.Email, false);
                if (login.LogInAs == 1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (login.LogInAs == 2)
                {
                    return RedirectToAction("Index", "This");
                }
                else
                {
                    return Redirect("/");
                }
            }
            else
            {
                return View(login);
            }
        }

        private bool IsValid(Login login)
        {
            return (login.Email == "test" && login.Password == "test");
        }

    }
}