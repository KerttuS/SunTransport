using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunTransport.Startup))]
namespace SunTransport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
