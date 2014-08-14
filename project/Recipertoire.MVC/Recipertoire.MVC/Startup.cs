using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recipertoire.MVC.Startup))]
namespace Recipertoire.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
