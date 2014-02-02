using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOLID.Web.Startup))]
namespace SOLID.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
