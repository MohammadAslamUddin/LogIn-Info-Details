using LogInInfoDetails.Gateway;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LogInInfoDetails.Manager
{
    public class AppUserManager
    {
        private AppUserGateway appUserGateway;

        public AppUserManager()
        {
            appUserGateway = new AppUserGateway();
        }

        public List<SelectListItem> LogIn()
        {
            List<SelectListItem> logIn = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "1", Text = "Teacher"},
                new SelectListItem(){Value = "2", Text = "Student"}
            };
            return logIn;
        }
    }
}