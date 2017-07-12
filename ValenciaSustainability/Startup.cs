using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValenciaSustainability.Startup))]
namespace ValenciaSustainability
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
