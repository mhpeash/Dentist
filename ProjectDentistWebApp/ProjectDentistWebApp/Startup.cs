using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectDentistWebApp.Startup))]
namespace ProjectDentistWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
