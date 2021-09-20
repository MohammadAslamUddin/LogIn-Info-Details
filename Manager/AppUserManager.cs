using LogInInfoDetails.Gateway;

namespace LogInInfoDetails.Manager
{
    public class AppUserManager
    {
        private AppUserGateway appUserGateway;

        public AppUserManager()
        {
            appUserGateway = new AppUserGateway();
        }
    }
}