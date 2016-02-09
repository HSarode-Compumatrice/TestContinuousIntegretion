using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Continuous_integration.Startup))]
namespace Continuous_integration
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
