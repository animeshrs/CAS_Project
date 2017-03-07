using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAS_Web.Startup))]
namespace CAS_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
