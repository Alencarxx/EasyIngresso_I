using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyIngresso.WEB.Startup))]
namespace EasyIngresso.WEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
