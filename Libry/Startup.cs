using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Libry.Startup))]
namespace Libry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
