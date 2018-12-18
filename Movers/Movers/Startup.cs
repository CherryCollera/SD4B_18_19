using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movers.Startup))]
namespace Movers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
