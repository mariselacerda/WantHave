using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WantHaveSite.Startup))]
namespace WantHaveSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
