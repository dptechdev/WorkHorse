using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkHorse.WebUI.Startup))]
namespace WorkHorse.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
