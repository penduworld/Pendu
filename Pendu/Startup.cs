using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pendu.Startup))]
namespace Pendu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
