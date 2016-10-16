using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistProject.Startup))]
namespace DentistProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
