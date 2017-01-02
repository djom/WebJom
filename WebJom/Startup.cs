using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebJom.Startup))]
namespace WebJom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
