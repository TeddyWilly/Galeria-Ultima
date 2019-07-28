using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaleriadeArte_1.Startup))]
namespace GaleriadeArte_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
