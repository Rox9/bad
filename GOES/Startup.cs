using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GOES.Startup))]
namespace GOES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
