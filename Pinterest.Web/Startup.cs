using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pinterest.Web.Startup))]
namespace Pinterest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
