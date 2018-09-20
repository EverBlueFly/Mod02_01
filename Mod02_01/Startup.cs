using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod02_01.Startup))]
namespace Mod02_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
