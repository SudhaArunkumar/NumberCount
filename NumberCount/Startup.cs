using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumberCount.Startup))]
namespace NumberCount
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
