using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DATennis.Startup))]
namespace DATennis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
