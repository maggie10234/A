using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSaleX.Startup))]
namespace eSaleX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
