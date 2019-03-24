using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Velinov2.Startup))]
namespace Velinov2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
