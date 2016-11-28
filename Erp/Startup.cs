using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Erp.Startup))]
namespace Erp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
