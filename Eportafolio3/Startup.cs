using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eportafolio3.Startup))]
namespace Eportafolio3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
