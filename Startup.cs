using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogInInfoDetails.Startup))]
namespace LogInInfoDetails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
