using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aquafarms.Startup))]
namespace Aquafarms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
