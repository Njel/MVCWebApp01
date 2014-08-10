using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebApp01.Startup))]
namespace MVCWebApp01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
