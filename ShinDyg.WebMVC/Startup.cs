using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShinDyg.WebMVC.Startup))]
namespace ShinDyg.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
