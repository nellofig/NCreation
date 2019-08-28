using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCreation.Web.Startup))]
namespace NCreation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
