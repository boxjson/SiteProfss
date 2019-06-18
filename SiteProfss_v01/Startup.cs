using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteProfss_v01.Startup))]
namespace SiteProfss_v01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
