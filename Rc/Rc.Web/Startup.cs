using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rc.Web.Startup))]
namespace Rc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
