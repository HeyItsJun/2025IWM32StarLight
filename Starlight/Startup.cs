using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Starlight.Startup))]
namespace Starlight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
